namespace JCat.Config.Mysql;

public static class ConfigConst
{
    private const string ApplicationConnectionPrefix = "application.";
    public static string GetAppliationConnectionKey(string applicationName) => $"{ApplicationConnectionPrefix}{applicationName.ToLower()}";

    private const string ApplicationConnectionStringPrefix = "mysql.connection.string.";
    public static string GetAppliationSqlConnectionString(string applicationName) => $"{ApplicationConnectionStringPrefix}{applicationName.ToLower()}";
}

