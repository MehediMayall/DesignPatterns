namespace BuilderPattern;

public class SqlServerDatabaseBuilder : IDatabaseBuilder
{
    private IDatabase database;
    public SqlServerDatabaseBuilder()
    {
        database = new SqlServerDatabase();
    }
    public IDatabaseBuilder BuildCommand()
    {
        database.Command = new SqlCommand();
        database.Command.Connection = database.Connection;
        return this;
    }

    public IDatabaseBuilder BuildConnection()
    {
        string cstr = "";
        database.Connection = new SqlConnection(cstr);
        return this;
    }

    public IDatabaseBuilder SetSettings(int Timeout = 360, CommandType commandType = CommandType.Text)
    {
        database.Command.CommandTimeout = Timeout;
        database.Command.CommandType = commandType;
        return this;
    }

    public IDatabase Build() => this.database;

}