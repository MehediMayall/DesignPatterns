namespace FactoryMethod;

public class DatabaseFactory
{
    public static IDatabase Create(DatabaseType databaseType)
    {
        return databaseType switch{
            DatabaseType.SQL_SERVER => new SqlServerDatabase(),
            DatabaseType.SQLite => new SqliteDatabase(),
            _ => new SqlServerDatabase(),
        };
    }
}
