using FactoryMethod;


// Creating Sql Server Database Connection
// IDatabase db = DatabaseFactory.Create(DatabaseType.SQL_SERVER);

// Creating Sqlite Database Connection
IDatabase db = DatabaseFactory.Create(DatabaseType.SQLite);




// Database Operations
using DbCommand dbCommand = db.Command;

dbCommand.CommandType = CommandType.Text;
dbCommand.CommandText = "SELECT * FROM Customers";
dbCommand.Connection.Open();

using DbDataReader reader = dbCommand.ExecuteReader();
dbCommand.Connection.Close();