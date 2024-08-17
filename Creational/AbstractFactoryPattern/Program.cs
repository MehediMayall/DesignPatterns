using AbstractFactory;


// Connecting Sql Server
// Database db = new SqlServerDatabase();


// Connecting Sqlite 
Database db = new SqliteDatabase();



// Database Operations

using DbCommand dbCommand = db.Command;

dbCommand.CommandType = CommandType.Text;
dbCommand.CommandText = "SELECT * FROM Customers";
dbCommand.Connection.Open();

using DbDataReader reader = dbCommand.ExecuteReader();
dbCommand.Connection.Close();