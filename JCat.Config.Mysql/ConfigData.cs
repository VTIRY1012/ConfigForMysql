using JCat.Mysql.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace JCat.Config.Mysql;

public class ConfigData : JCatDbContext
{
    public DbSet<ConfigEntity> CONFIG { get; set; }
}