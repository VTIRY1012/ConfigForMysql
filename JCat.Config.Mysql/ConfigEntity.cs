using JCat.Mysql.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace JCat.Config.Mysql;

public class ConfigEntity : BaseEntity
{
    [Key]
    public string Id { get; set; } = string.Empty;
    public string Key { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public int Version { get; set; } = 1;
}