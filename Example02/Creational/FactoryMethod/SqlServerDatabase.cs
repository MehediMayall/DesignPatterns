namespace FactoryMethod;

public class SqlServerDatabase: IDatabase
{
    private IDbConnection connection = null;
    private IDbCommand command = null;

    public IDbConnection Connection
    {
        get { 
            if (connection == null)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("AppSettings.json", optional: false);

                var config = builder.Build();
                var cstr = config.GetSection("ConnectionStrings").GetSection("SqlServer").Value;
                Console.WriteLine(cstr);
                connection = new SqlConnection(cstr);
            }
            return connection; 
        }
    }

    public IDbCommand Command
    {
        get {
            if (command == null)
            {
                command = new SqlCommand();
                command.Connection = this.Connection;
            }
            return command;
        }
    }
}