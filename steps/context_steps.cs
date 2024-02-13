/*
 SET CONNECTION TO DB :
 1-set connection strings in appsettings file
 2-build servese and call connection strings in program.cs file
 3-create context class and constructer and send options:
    --create dbset<modelNmae> TableName
 4-migration in terminal:
    --create migration model
    --migrate to db   
    the command: to add migration 
    dotnet ef migrations add YourMigrationName
    
*/