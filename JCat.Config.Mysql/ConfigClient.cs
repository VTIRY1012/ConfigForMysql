using JCat.Mysql.DataAccess.Enum;
using System.Text.Json;

namespace JCat.Config.Mysql;

public class ConfigClient
{
    public void GetApplicationConfig(string applicationName)
    {
        using var context = new ConfigData();
        var entity = context.CONFIG
            .Where(p => p.Key == ConfigConst.GetAppliationConnectionKey(applicationName) && p.Status == TableStatusEnum.Normal.ToString())
            .FirstOrDefault();

        if (entity == null)
        {
            throw new ArgumentNullException(ConfigMessage.ApplicationValuesError);
        }

        var keys = JsonSerializer.Deserialize<List<string>>(entity.Value);
        var entities = context.CONFIG
            .Where(p => keys.Contains(p.Key) && p.Status == TableStatusEnum.Normal.ToString())
            .ToList();

        ConfigSettings.InitializeSettings(entities);
    }
}