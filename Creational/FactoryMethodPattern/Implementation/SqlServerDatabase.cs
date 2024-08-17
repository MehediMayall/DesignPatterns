namespace FactoryMethod;

public class SqlServerDatabase: IDatabase
{
    private DbConnection connection;
    private DbCommand command;

    public DbConnection Connection
    {
        get {
            string cstr = "";
            return connection = connection ?? new SqlConnection(cstr);
        }
        set => connection = value; 
    }

    public DbCommand Command
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
