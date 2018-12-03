using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BLOX.IR.CodeGenerator
{
    public partial class frmCodeGenerator : Form
    {
        #region Props
        private string[] standardColumns = new string[] { "InsertUserAccountId", "InsertDateTime", "UpdateUserAccountId", "UpdateDateTime", "Version" };
        #endregion

        #region Ctor
        public frmCodeGenerator()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnLoadWebConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (opSelectConfigFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = opSelectConfigFile.FileName;
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(path);
                    XmlNodeList xList = xDoc.SelectNodes("configuration/connectionStrings/add");
                    foreach (XmlNode xn in xList)
                    {
                        XmlElement element = xn as XmlElement;
                        string name = element.GetAttribute("name");
                        string cs = element.GetAttribute("connectionString");
                        cbConnectionString.Items.Add(name + " ** " + cs);
                    }
                    cbConnectionString.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(getExceptionMessage(ex));
            }
        }
        private void btnSaveToDisk_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                TextBox[] boxStaticArray = new TextBox[] { txtContext, txtServiceGeneric, txtEOIBase, txtDataGeneric, txtServiceGeneric };
                TextBox[] boxDynamicArray = new TextBox[] { txtEO, txtData, txtService };
                if (cbSaveGeneric.Checked)
                {
                    foreach (var box in boxStaticArray)
                    {
                        StreamWriter sw = new StreamWriter(folder.SelectedPath + "\\" + box.Tag.ToString() + ".cs");
                        sw.Write(box.Text);
                        sw.Flush();
                        sw.Dispose();
                    }
                }
                foreach (var box in boxDynamicArray)
                {
                    StreamWriter sw = new StreamWriter(folder.SelectedPath + "\\" + cbTables.Text + box.Tag.ToString() + ".cs");
                    sw.Write(box.Text);
                    sw.Flush();
                    sw.Dispose();
                }
                MessageBox.Show("Files has been created ...");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = getConnectionString(cbConnectionString.Text);
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                DataTable table = conn.GetSchema("Tables");
                cbTables.Items.Clear();
                foreach (System.Data.DataRow row in table.Rows)
                {
                    foreach (System.Data.DataColumn col in table.Columns)
                    {
                        if (col.ColumnName == "TABLE_NAME")
                        {
                            cbTables.Items.Add(row[col]);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(getExceptionMessage(ex));
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                txtEO.Text = generateEO();
                txtData.Text = generateData();
                txtService.Text = generateService();
                txtContext.Text = generateContext();
                txtEOIBase.Text = generateIBase();
                txtDataGeneric.Text = generateDataGeneric();
                txtServiceGeneric.Text = generateServiceGeneric();
                btnSaveToDisk.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(getExceptionMessage(ex));
            }
        }
        #endregion

        #region GenerationMethods
        private string generateServiceGeneric()
        {
            string path = Application.StartupPath + "\\Patterns\\Pattern_ServiceGeneric.txt";
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string retVal = sr.ReadToEnd();
            sr.Dispose();

            retVal = retVal.Replace("BLOXNameSpace", txtNameSpace.Text);
            retVal = retVal.Replace("BLOXPrefix", txtPrefix.Text);
            retVal = retVal.Replace("PKType", cbPKType.Text);
            return retVal;
        }
        private string generateDataGeneric()
        {
            string path = Application.StartupPath + "\\Patterns\\Pattern_DataGeneric.txt";
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string retVal = sr.ReadToEnd();
            sr.Dispose();

            retVal = retVal.Replace("BLOXNameSpace", txtNameSpace.Text);
            retVal = retVal.Replace("BLOXPrefix", txtPrefix.Text);
            retVal = retVal.Replace("PKTypeIf", cbPKType.Text == "int" ? "0" : "new Guid()");
            retVal = retVal.Replace("PKTypeNew", cbPKType.Text == "int" ? "0" : "Guid.NewGuid()");
            retVal = retVal.Replace("PKType", cbPKType.Text);
            return retVal;
        }
        private string generateIBase()
        {
            string path = Application.StartupPath + "\\Patterns\\Pattern_BOIbase.txt";
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string retVal = sr.ReadToEnd();
            sr.Dispose();

            retVal = retVal.Replace("BLOXNameSpace", txtNameSpace.Text);
            retVal = retVal.Replace("PKType", cbPKType.SelectedText);

            return retVal;
        }
        private string generateContext()
        {
            string path = Application.StartupPath + "\\Patterns\\Pattern_Context.txt";
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string retVal = sr.ReadToEnd();
            sr.Dispose();

            string loop = retVal.Remove(0, retVal.IndexOf("<BLOX::Loop::TableForContext>") + "<BLOX::Loop::TableForContext>".Length);
            loop = loop.Remove(loop.IndexOf("</BLOX::Loop::TableForContext>"));

            List<string> tables = getTables();
            string tablesManipulates = string.Empty;
            foreach (var table in tables)
                tablesManipulates += loop.Replace("BLOXTableName", table);

            retVal = retVal.Replace("BLOXNameSpace", txtNameSpace.Text);
            retVal = retVal.Replace("BLOXPrefix", txtPrefix.Text);
            retVal = retVal.Replace(loop, tablesManipulates);
            retVal = retVal.Replace("<BLOX::Loop::TableForContext>", string.Empty);
            retVal = retVal.Replace("</BLOX::Loop::TableForContext>", string.Empty);
            return retVal;
        }
        private string generateData()
        {
            string path = Application.StartupPath + "\\Patterns\\Pattern_Data.txt";
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string retVal = sr.ReadToEnd();
            sr.Dispose();

            retVal = retVal.Replace("BLOXTableName", cbTables.Text);
            retVal = retVal.Replace("BLOXNameSpace", txtNameSpace.Text);
            return retVal;
        }
        private string generateService()
        {
            string path = Application.StartupPath + "\\Patterns\\Pattern_Service.txt";
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string retVal = sr.ReadToEnd();
            sr.Dispose();

            retVal = retVal.Replace("BLOXTableName", cbTables.Text);
            retVal = retVal.Replace("BLOXNameSpace", txtNameSpace.Text);
            retVal = retVal.Replace("BLOXPrefix", txtPrefix.Text);
            return retVal;
        }
        private string generateEO()
        {
            string path = Application.StartupPath + "\\Patterns\\Pattern_BO.txt";
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string retVal = sr.ReadToEnd();
            sr.Dispose();

            string loop = retVal.Remove(0, retVal.IndexOf("<BLOX::Loop::BLOXColumns>") + "<BLOX::Loop::BLOXColumns>".Length);
            loop = loop.Remove(loop.IndexOf("</BLOX::Loop::BLOXColumns>"));

            List<KeyValuePair<string, string>> columns = getColumns(cbTables.Text);
            string columnsManipulates = string.Empty;
            foreach (var column in columns)
            {
                if (isNotStandardColumns(column.Key))
                {
                    if (isPrimaryKeyColumn(column.Key, cbTables.Text))
                    {
                        string annotation = "[System.ComponentModel.DataAnnotations.Key]";
                        columnsManipulates += annotation + "\r\n";
                        columnsManipulates += loop.Replace("BLOXColumnName", column.Key).Replace("BLOXColumnType", GetClrType(column.Value));
                    }
                    else
                    {
                        columnsManipulates += loop.Replace("BLOXColumnName", column.Key).Replace("BLOXColumnType", GetClrType(column.Value));
                    }
                }
            }

            retVal = retVal.Replace("BLOXTableName", cbTables.Text);
            retVal = retVal.Replace("BLOXNameSpace", txtNameSpace.Text);
            retVal = retVal.Replace("BLOXPrefix", txtPrefix.Text);
            retVal = retVal.Replace("PKType", cbPKType.Text);
            retVal = retVal.Replace(loop, columnsManipulates);
            retVal = retVal.Replace("<BLOX::Loop::BLOXColumns>", string.Empty);
            retVal = retVal.Replace("</BLOX::Loop::BLOXColumns>", string.Empty);
            return retVal;
        }
        #endregion

        #region OtherMethods
        private bool isPrimaryKeyColumn(string column, string tableName)
        {
            return column.Equals(tableName + "Id");
        }
        private bool isNotStandardColumns(string column)
        {
            return !standardColumns.Contains(column);
        }
        private string getConnectionString(string input)
        {
            string[] csArray = input.Split(new string[] { "**" }, StringSplitOptions.RemoveEmptyEntries);
            string connectionString = csArray[1].Trim();
            if (connectionString.Contains("connection string="))
            {
                connectionString = connectionString.Remove(0, connectionString.IndexOf("connection string=\"") + "connection string=\"".Length);
                connectionString = connectionString.Remove(connectionString.IndexOf("\""));
            }
            return connectionString;
        }
        private List<KeyValuePair<string, string>> getColumns(string tableName)
        {
            List<KeyValuePair<string, string>> columns = new List<KeyValuePair<string, string>>();
            string connectionString = getConnectionString(cbConnectionString.Text);
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            String[] columnRestrictions = new String[4];
            DataTable departmentIDSchemaTable = conn.GetSchema("Columns", columnRestrictions);
            var selectedRows = from info in departmentIDSchemaTable.AsEnumerable()
                               select new
                               {
                                   TableCatalog = info["TABLE_CATALOG"],
                                   TableSchema = info["TABLE_SCHEMA"],
                                   TableName = info["TABLE_NAME"],
                                   ColumnName = info["COLUMN_NAME"],
                                   DataType = info["DATA_TYPE"]
                               };
            var columnNames = selectedRows.Where(a => a.TableName.ToString().Equals(cbTables.Text));
            foreach (var row in columnNames)
            {
                columns.Add(new KeyValuePair<string, string>(row.ColumnName.ToString(), row.DataType.ToString()));
            }
            return columns;
        }
        private List<string> getTables()
        {
            List<string> tables = new List<string>();
            string connectionString = getConnectionString(cbConnectionString.Text);
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            DataTable table = conn.GetSchema("Tables");
            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    if (col.ColumnName == "TABLE_NAME")
                    {
                        tables.Add(row[col].ToString());
                        break;
                    }
                }
            }
            return tables;
        }
        public string GetClrType(string sqlType)
        {
            switch (sqlType)
            {
                case "bigint":
                    return "long";

                case "binary":
                case "image":
                case "timestamp":
                case "varbinary":
                    return "byte[]";

                case "bit":
                    return "bool";

                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar":
                case "xml":
                    return "string";

                case "datetime":
                case "smalldatetime":
                case "date":
                case "time":
                case "datetime2":
                    return "DateTime";

                case "decimal":
                case "money":
                case "smallmoney":
                    return "decimal";

                case "float":
                    return "double";

                case "int":
                    return "int";

                case "real":
                    return "float";

                case "uniqueidentifier":
                    return "Guid";

                case "smallint":
                    return "short";

                case "tinyint":
                    return "byte";

                case "variant":
                case "udt":
                    return "object";

                case "structured":
                    return "DataTable";

                case "datetimeoffset":
                    return "DateTimeOffset";

                case "geography":
                    return "Location";

                default:
                    throw new ArgumentOutOfRangeException("sqlType " + sqlType);
            }
        }
        private string getExceptionMessage(Exception ex)
        {
            string message = ex.Message;
            if (ex.InnerException != null)
            {
                message += "\r\n" + ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                {
                    message += "\r\n" + ex.InnerException.InnerException.Message;
                    if (ex.InnerException.InnerException.InnerException != null)
                    {
                        message += "\r\n" + ex.InnerException.InnerException.InnerException.Message;
                    }
                }
            }
            return message;
        }
        #endregion
    }
}
