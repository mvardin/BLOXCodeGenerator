# BLOXCodeGenerator

To create 3 layers project with .net

# About

You can this code generator for generating 3 layers of a 3 layers project ...

the structure of this framework can be such this :

1- SampleNamespace.BO

2- SampleNamespace.Data

3- SampleNamespace.Service

4- SampleNamespace.AnyUI


# Description

1- This layer used in all of the layers , it contains entity , object , display object , enums and ...

  it shared with all layers
  
2- This layer contains DBContext , data repository , data layet and ...
  it share with service layer only
  
3- This layer contains generic repository , services , busines and ...
  it share with ui layer only
  
4- UI layer can be anything , windows application , web application , web api and ...

# HowCanIUseIt

1- Just create 3 projects BO , Data , Service

2- Use code generator foe creating code files we need

3- Copy Bo files to .BO 

4- Copy Data files to .Data

5- Copy Service files to .Service

6- if you marked generating generics

  a- Copy IBaseBO to .BO
  
  b- Copy GenericRepository to .Data
  
  c- Copy GenericService to .Service
  
  d- Copy Context to .Data
  
  7- From nuget , you must add EntityFramework to layers UI and Data ...
  
      Install-Package EntityFramework -Version 6.2.0	
