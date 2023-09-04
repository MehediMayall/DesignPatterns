using FactoryMethod;

IDatabase database = DatabaseFactory.CreateDatabase(DatabaseTypes.SqlServer);
IDbCommand command = database.Command;

command.CommandType = CommandType.Text;
command.CommandText = "SELECT Email FROM DBO.users";

command.Connection.Open();

IDataReader reader = command.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(reader.GetValue(0));
}

reader.Read();
command.Connection.Close();


