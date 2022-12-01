using JCat.Mysql.DataAccess.Util;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace JCat.Config.Mysql;

public static class ConfigExtension
{
    public static IWebHostBuilder ConfigureConnectionStringRuntime(this IWebHostBuilder builder, string applicationName)
    {
        builder.ConfigureAppConfiguration(delegate (WebHostBuilderContext context, IConfigurationBuilder builder)
        {
            var configConnectionStringConst = "CONFIG_SQL_CONNECTION_STRING";
            var configConnectionString = context.Configuration[configConnectionStringConst];
            ConfigUtil.InitializeMysql(configConnectionString);
            var configClinet = new ConfigClient();
            configClinet.GetApplicationConfig(applicationName);
            var applicationConnectionString = ConfigSettings.Settings.SingleOrDefault(p => p.Key == ConfigConst.GetAppliationSqlConnectionString(applicationName)).Value;
            ConfigUtil.InitializeMysql(applicationConnectionString);
        });
        return builder;
    }
}