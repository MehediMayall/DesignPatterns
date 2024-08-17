namespace BuilderPattern;

public class SqliteDatabaseBuilder : IDatabaseBuilder
{
    private IDatabase database;
    public SqliteDatabaseBuilder()
    {
        database = new SqliteDatabase();
    }
    public void BuildCommand()
    {
        database.Command = new SqliteCommand();
        database.Command.Connection = database.Connection;
    }

    public void BuildConnection()
    {
        string cstr = "";
        database.Connection = new SqliteConnection(cstr);
    }

    public void SetSettings()
    {
        database.Command.CommandTimeout = 360;
        database.Command.CommandType = CommandType.Text;
    }

    public IDatabase Database { get=> database;}
}
