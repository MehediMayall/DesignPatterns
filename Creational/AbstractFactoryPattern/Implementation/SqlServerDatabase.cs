namespace AbstractFactory;

public class SqlServerDatabase: Database
{
    private DbConnection connection;
    private DbCommand command;

    public override DbConnection Connection
    {
        get {
            string cstr = "";
            return connection = connection ?? new SqlConnection(cstr);
        }
        set => connection = value; 
    }

    public override DbCommand Command
    {
        get {
            if( command is null){
                command = new SqlCommand();
                command.Connection = Connection;
            }
            return command;
        }
        set => command =  value;
    }
}
