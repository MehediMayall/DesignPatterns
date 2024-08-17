using BuilderPattern;




// Creating Sql Server Database Connection
IDatabaseBuilder builder = new SqlServerDatabaseBuilder();
Director.Build(builder);
IDatabase db = builder.Database;

// Creating Sqlite Database Connection
// IDatabaseBuilder builder = new SqliteDatabaseBuilder();
// Director.Build(builder);
// IDatabase db = builder.Database;




// Database Operations
using DbCommand dbCommand = db.Command;

dbCommand.CommandText = "SELECT * FROM Customers";
dbCommand.Connection.Open();

using DbDataReader reader = dbCommand.ExecuteReader();
dbCommand.Connection.Close();