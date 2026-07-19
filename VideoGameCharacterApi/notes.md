

## Packages
dotnet add package Scalar.AspNetCore
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

## SQL scripts

### Migration
dotnet ef
cd path/to/YourProject
dotnet ef migrations add Initial
dotnet ef database update