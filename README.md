AspNetCore.WithFrameworkSource.EntityFramework.2.0
====

Sample project with Entity Framework Core source codes.

## Description
Do you want to read the framework source code, and deepen your understanding, like scripting languages such as PHP, Python, Ruby, Javascript?  
This is a ASP.Net Core template project that switched reference NuGet-packages to framework source codes.  
All projects sources included in this solution can rewrite, build, run, break, step-in.

Target: Entity Framework Core 2.0  

## Requirement
Visual Studio 2017
  

## Usage
1. Git clone, or Download this.  
2. WithSource.All.sln file on Visual Studio.
3. Rewrite, build, run, break, step-in, As you like!

Note:  
In this project, it is not possible to verify database migration, code first action, scaffolding.  
To run this, please restore /DbDump/testdb.bak to your SqlServer first.  


## Dependency-Tree  
Referenced NuGet packages:
   
- Basic Reference:
    + [Microsoft.AspNetCore](https://github.com/aspnet/MetaPackages/tree/rel/2.0.0/src/Microsoft.AspNetCore)
    + [Microsoft.AspNetCore.Mvc](https://github.com/aspnet/Mvc/tree/rel/2.0.0)
    + [Microsoft.AspNetCore.StaticFiles](https://github.com/aspnet/StaticFiles/tree/rel/2.0.0)  
    + Microsoft.VisualStudio.Web.BrowserLink <- source not found. MetaPackage?
- Entity Framework sources
    + [Microsoft.EntityFrameworkCore](https://github.com/aspnet/EntityFrameworkCore/tree/rel/2.0.0/src/EFCore)
        * [Microsoft.EntityFrameworkCore.Design](https://github.com/aspnet/EntityFrameworkCore/tree/rel/2.0.0/src/EFCore.Design)
        * [Microsoft.EntityFrameworkCore.SqlServer](https://github.com/aspnet/EntityFrameworkCore/tree/rel/2.0.0/src/EFCore.SqlServer)
    
  
## Link
Asp.Net Core Project Home:  
[https://github.com/aspnet/Home](https://github.com/aspnet/Home)  
  
Package Set:  
[https://github.com/aspnet/MetaPackages](https://github.com/aspnet/MetaPackages)  
  
Namespace "Microsoft.EntityFrameworkCore" Packages:  
[https://github.com/aspnet/EntityFrameworkCore](https://github.com/aspnet/EntityFrameworkCore)  
  
Namespace "Microsoft.AspNetCore" Packages:   
[https://github.com/aspnet/Mvc](https://github.com/aspnet/Mvc)  
[https://github.com/aspnet/StaticFiles](https://github.com/aspnet/StaticFiles)  
   

## Licence
Apache License, Version 2.0 [(conforms to the original source code: https://github.com/aspnet/Home/blob/dev/LICENSE.txt)](https://github.com/aspnet/Home/blob/dev/LICENSE.txt)



