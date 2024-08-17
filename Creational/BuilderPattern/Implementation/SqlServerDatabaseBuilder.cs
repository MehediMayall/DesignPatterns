namespace BuilderPattern;

public class SqlServerDatabaseBuilder : IDatabaseBuilder
{
    private IDatabase database;
    public SqlServerDatabaseBuilder()
    {
        database = new SqlServerDatabase();
    }
    public void BuildCommand()
    {
        database.Command = new SqlCommand();
        database.Command.Connection = database.Connection;
    }

    public void BuildConnection()
    {
        string cstr = "";
        database.Connection = new SqlConnection(cstr);
    }

    public void SetSettings()
    {
        database.Command.CommandTimeout = 360;
        database.Command.CommandType = CommandType.Text;
    }
    public IDatabase Database { get=> database;}

}