namespace FactoryMethod;

public class SqliteDatabase: IDatabase
{
    private DbConnection connection;
    private DbCommand command;

    public DbConnection Connection
    {
        get {
            string cstr = "";
            return connection = connection ?? new SqliteConnection(cstr);
        }
        set => connection = value; 
    }

    public DbCommand Command
    {
        get {
            if( command is null){
                command = new SqliteCommand();
                command.Connection = Connection;
            }
            return command;
        }
        set => command =  value;
    }
}