using BuilderPattern;




// Creating Sql Server Database Connection
// IDatabase db = new SqlServerDatabaseBuilder()
//     .BuildConnection()
//     .BuildCommand()
//     .SetSettings()
//     .Build();
    

// Creating Sqlite Database Connection
IDatabase db = new SqliteDatabaseBuilder()
    .BuildConnection()
    .BuildCommand()
    .SetSettings(420, CommandType.Text)
    .Build(); 


// Database Operations
using DbCommand dbCommand = db.Command;

dbCommand.CommandText = "SELECT * FROM Customers";
dbCommand.Connection.Open();

using DbDataReader reader = dbCommand.ExecuteReader();
dbCommand.Connection.Close();