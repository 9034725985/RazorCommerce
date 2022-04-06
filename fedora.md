watch : Hot reload enabled. For a list of supported edits, see https://aka.ms/dotnet/hot-reload. Press "Ctrl + R" to restart.
watch : Building...
  Determining projects to restore...
  All projects are up-to-date for restore.
  RazorCommerce -> /home/kushal/src/dotnet/RazorCommerce/RazorCommerce/bin/Debug/net6.0/RazorCommerce.dll
watch : Started
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5000
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:5001
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[0]
      Content root path: /home/kushal/src/dotnet/RazorCommerce/RazorCommerce/
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...
watch : Shutdown requested. Press Ctrl+C again to force exit.
Building...
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://0.0.0.0:7279
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://0.0.0.0:5279
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[0]
      Content root path: /home/kushal/src/dotnet/RazorCommerce/RazorCommerce/
[40m[32minfo[39m[22m[49m: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.1 initialized 'ApplicationDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer:6.0.1' with options: None
[40m[1m[33mwarn[39m[22m[49m: Microsoft.EntityFrameworkCore.Query[10114]
      The query uses the 'Distinct' operator after applying an ordering. If there are any row limiting operation used before 'Distinct' and after ordering then ordering will be used for it. Ordering(s) will be erased after 'Distinct' and results afterwards would be unordered.
[40m[32minfo[39m[22m[49m: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (65ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT DISTINCT [m].[Genre]
      FROM [Movie] AS [m]
[40m[32minfo[39m[22m[49m: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (22ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [m].[ID], [m].[Genre], [m].[Price], [m].[Rating], [m].[ReleaseDate], [m].[Title]
      FROM [Movie] AS [m]
[40m[32minfo[39m[22m[49m: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...
