namespace AbstractFactory;

public class SqliteDatabase: Database
{
    private DbConnection connection;
    private DbCommand command;

    public override DbConnection Connection
    {
        get {
            string cstr = "";
            return connection = connection ?? new SqliteConnection(cstr);
        }
        set => connection = value; 
    }

    public override DbCommand Command
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