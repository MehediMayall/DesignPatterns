

namespace AbstractFactory;

public abstract class Database
{
    public abstract DbConnection Connection {get; set;}
    public abstract DbCommand Command {get; set;}
}
