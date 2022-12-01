#JCat.Package

1.before start:

create config database.
excute [Sql/Table].

2.example:

var builder = WebApplication.CreateBuilder(args);
// get from config database
string applicationName = ""; // if use JCat.BaseService, please use [EnvironmentMode.RunTimeSettings.Application.ApplicationName];
builder.WebHost.ConfigureConnectionStringRuntime(applicationName);
var app = builder.Build();
app.Run();

3.default rule:
launchSettings.json use [CONFIG_SQL_CONNECTION_STRING] connect config database.
config database default read key - 
	1. [application.] read all application keys.
	2. [mysql.connection.string.] read application database connection string.

// if use JCat.BaseService.
launchSettings.json use [ApplicationName] get application info.
