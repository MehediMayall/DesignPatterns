namespace BuilderPattern;

public interface IDatabase
{
    DbConnection Connection {get; set;}
    DbCommand Command {get; set;}
}
