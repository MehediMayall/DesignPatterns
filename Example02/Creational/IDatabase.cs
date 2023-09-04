using System.Data;
using System.Data.Common;


namespace Creational;

public interface IDatabase
{
    IDBConnection Connection { get; }
    IDBCommand  Command { get; }
}