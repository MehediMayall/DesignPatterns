namespace BuilderPattern;

public class SqliteDatabaseBuilder : IDatabaseBuilder
{
    private IDatabase database;
    public SqliteDatabaseBuilder()
    {
        database = new SqliteDatabase();
    }
    public IDatabaseBuilder BuildCommand()
    {
        database.Command = new SqliteCommand();
        database.Command.Connection = database.Connection;
        return this;
    }

    public IDatabaseBuilder BuildConnection()
    {
        string cstr = "";
        database.Connection = new SqliteConnection(cstr);
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
