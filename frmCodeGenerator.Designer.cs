namespace BLOX.IR.CodeGenerator
{
    partial class frmCodeGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.opSelectConfigFile = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEO = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbConnectionString = new System.Windows.Forms.ComboBox();
            this.btnLoadWebConfig = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtEOIBase = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtServiceGeneric = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtDataGeneric = new System.Windows.Forms.TextBox();
            this.btnSaveToDisk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPKType = new System.Windows.Forms.ComboBox();
            this.cbSaveGeneric = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1- web.config";
            // 
            // opSelectConfigFile
            // 
            this.opSelectConfigFile.FileName = "openFileDialog1";
            this.opSelectConfigFile.Filter = "Wen.Config File | Web.Config";
            this.opSelectConfigFile.Title = "Select Wen.Config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "2- Select Tables";
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(149, 54);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(545, 21);
            this.cbTables.Sorted = true;
            this.cbTables.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEO);
            this.groupBox1.Location = new System.Drawing.Point(194, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 213);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BO";
            // 
            // txtEO
            // 
            this.txtEO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEO.Location = new System.Drawing.Point(3, 16);
            this.txtEO.Multiline = true;
            this.txtEO.Name = "txtEO";
            this.txtEO.Size = new System.Drawing.Size(151, 194);
            this.txtEO.TabIndex = 9;
            this.txtEO.Tag = "BO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Location = new System.Drawing.Point(366, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 213);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(3, 16);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(151, 194);
            this.txtData.TabIndex = 8;
            this.txtData.Tag = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtService);
            this.groupBox3.Location = new System.Drawing.Point(540, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 213);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service";
            // 
            // txtService
            // 
            this.txtService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtService.Location = new System.Drawing.Point(3, 16);
            this.txtService.Multiline = true;
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(151, 194);
            this.txtService.TabIndex = 9;
            this.txtService.Tag = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "3- Namespace";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(149, 93);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(545, 20);
            this.txtNameSpace.TabIndex = 4;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(149, 125);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(545, 20);
            this.txtPrefix.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "4- Prefix";
            // 
            // cbConnectionString
            // 
            this.cbConnectionString.FormattingEnabled = true;
            this.cbConnectionString.Location = new System.Drawing.Point(206, 27);
            this.cbConnectionString.Name = "cbConnectionString";
            this.cbConnectionString.Size = new System.Drawing.Size(434, 21);
            this.cbConnectionString.TabIndex = 1;
            // 
            // btnLoadWebConfig
            // 
            this.btnLoadWebConfig.Location = new System.Drawing.Point(149, 25);
            this.btnLoadWebConfig.Name = "btnLoadWebConfig";
            this.btnLoadWebConfig.Size = new System.Drawing.Size(51, 23);
            this.btnLoadWebConfig.TabIndex = 0;
            this.btnLoadWebConfig.Text = "Select";
            this.btnLoadWebConfig.UseVisualStyleBackColor = true;
            this.btnLoadWebConfig.Click += new System.EventHandler(this.btnLoadWebConfig_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(643, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(51, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(174, 168);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(326, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate ...";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtContext);
            this.groupBox4.Location = new System.Drawing.Point(543, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 213);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data/Context";
            // 
            // txtContext
            // 
            this.txtContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContext.Location = new System.Drawing.Point(3, 16);
            this.txtContext.Multiline = true;
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(151, 194);
            this.txtContext.TabIndex = 11;
            this.txtContext.Tag = "DBContext";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtEOIBase);
            this.groupBox5.Location = new System.Drawing.Point(16, 416);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(157, 213);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EO/IBaseBO.cs";
            // 
            // txtEOIBase
            // 
            this.txtEOIBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEOIBase.Location = new System.Drawing.Point(3, 16);
            this.txtEOIBase.Multiline = true;
            this.txtEOIBase.Name = "txtEOIBase";
            this.txtEOIBase.Size = new System.Drawing.Size(151, 194);
            this.txtEOIBase.TabIndex = 11;
            this.txtEOIBase.Tag = "IBaseBO";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtServiceGeneric);
            this.groupBox7.Location = new System.Drawing.Point(370, 416);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(157, 213);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Service/GenericService.cs";
            // 
            // txtServiceGeneric
            // 
            this.txtServiceGeneric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServiceGeneric.Location = new System.Drawing.Point(3, 16);
            this.txtServiceGeneric.Multiline = true;
            this.txtServiceGeneric.Name = "txtServiceGeneric";
            this.txtServiceGeneric.Size = new System.Drawing.Size(151, 194);
            this.txtServiceGeneric.TabIndex = 12;
            this.txtServiceGeneric.Tag = "GenericService";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtDataGeneric);
            this.groupBox8.Location = new System.Drawing.Point(198, 416);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(157, 213);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Data/GenericRepository.cs";
            // 
            // txtDataGeneric
            // 
            this.txtDataGeneric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataGeneric.Location = new System.Drawing.Point(3, 16);
            this.txtDataGeneric.Multiline = true;
            this.txtDataGeneric.Name = "txtDataGeneric";
            this.txtDataGeneric.Size = new System.Drawing.Size(151, 194);
            this.txtDataGeneric.TabIndex = 11;
            this.txtDataGeneric.Tag = "GenericRepository";
            // 
            // btnSaveToDisk
            // 
            this.btnSaveToDisk.Enabled = false;
            this.btnSaveToDisk.Location = new System.Drawing.Point(506, 168);
            this.btnSaveToDisk.Name = "btnSaveToDisk";
            this.btnSaveToDisk.Size = new System.Drawing.Size(188, 23);
            this.btnSaveToDisk.TabIndex = 23;
            this.btnSaveToDisk.Text = "Save To Disk";
            this.btnSaveToDisk.UseVisualStyleBackColor = true;
            this.btnSaveToDisk.Click += new System.EventHandler(this.btnSaveToDisk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "5- PK";
            // 
            // cbPKType
            // 
            this.cbPKType.FormattingEnabled = true;
            this.cbPKType.Items.AddRange(new object[] {
            "int",
            "Guid"});
            this.cbPKType.Location = new System.Drawing.Point(65, 213);
            this.cbPKType.Name = "cbPKType";
            this.cbPKType.Size = new System.Drawing.Size(70, 21);
            this.cbPKType.TabIndex = 25;
            this.cbPKType.Text = "int";
            // 
            // cbSaveGeneric
            // 
            this.cbSaveGeneric.AutoSize = true;
            this.cbSaveGeneric.Location = new System.Drawing.Point(19, 259);
            this.cbSaveGeneric.Name = "cbSaveGeneric";
            this.cbSaveGeneric.Size = new System.Drawing.Size(97, 17);
            this.cbSaveGeneric.TabIndex = 27;
            this.cbSaveGeneric.Text = "Save Generic?";
            this.cbSaveGeneric.UseVisualStyleBackColor = true;
            // 
            // frmCodeGenerator
            // 
            this.AcceptButton = this.btnSaveToDisk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 637);
            this.Controls.Add(this.cbSaveGeneric);
            this.Controls.Add(this.cbPKType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaveToDisk);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnLoadWebConfig);
            this.Controls.Add(this.cbConnectionString);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNameSpace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCodeGenerator";
            this.Text = "BLOX Code Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog opSelectConfigFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtEO;
        private System.Windows.Forms.ComboBox cbConnectionString;
        private System.Windows.Forms.Button btnLoadWebConfig;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtEOIBase;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtServiceGeneric;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtDataGeneric;
        private System.Windows.Forms.Button btnSaveToDisk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPKType;
        private System.Windows.Forms.CheckBox cbSaveGeneric;
    }
}

