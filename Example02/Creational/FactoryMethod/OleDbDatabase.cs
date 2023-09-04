namespace FactoryMethod;

public class OleDbDatabase: IDatabase
{
    private IDbConnection connection = null;
    private IDbCommand command = null; 
    
    public IDbConnection Connection
    {
        get { 
            // Lazy Loading
            if (connection == null) 
            {
                var cstr = "";
                connection = new OleDbConnection(cstr);
            }
            return connection; 
        }
    }

    public IDbCommand Command
    {
        get {
            if (command == null)
            {
                command = new OleDbCommand();
                command.Connection = (OleDbConnection) this.Connection;
            }
            return command;
        }
    }
}