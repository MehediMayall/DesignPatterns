namespace FactoryMethod;

public class DatabaseFactory
{

    // Factory Method
    public static IDatabase CreateDatabase(DatabaseTypes databaseTypes)
    {
        return databaseTypes switch
        {
            DatabaseTypes.OleDb => new OleDbDatabase(),

            DatabaseTypes.SqlServer => new SqlServerDatabase(),

        };
    }
}