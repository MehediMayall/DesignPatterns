namespace BuilderPattern;

public class SqlServerDatabase: IDatabase
{
    private DbConnection connection;
    private DbCommand command;

    public DbConnection Connection
    {
        get => connection;
        set => connection = value; 
    }

    public DbCommand Command
    {
        get => command;
        set => command =  value;
    }
}
