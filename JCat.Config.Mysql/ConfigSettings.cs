namespace JCat.Config.Mysql;

public static class ConfigSettings
{
    public static Dictionary<string, string> Settings { get; private set; }
    public static void InitializeSettings(List<ConfigEntity> entities)
    {
        Settings = entities.ToDictionary(p=> p.Key, p=> p.Value);
        foreach (var setting in Settings)
        {
            Console.WriteLine($"[ConfigData] - key: {setting.Key}, value: {setting.Value}");
        }
    }
}