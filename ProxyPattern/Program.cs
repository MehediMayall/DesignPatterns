
string filename = "file.txt";
File.Delete(filename);


// Before using proxy class
// Write some text to the same file parallely will result wrong output
// Parallel.For(0,10, i => File.AppendAllText(filename, $"{i}, "));


// Using proxy class
Parallel.For(0,10, i => OneFileAtATimeProxy.AppendAllText(filename, $"{i}, "));



class OneFileAtATimeProxy
{
    static readonly object FileInUse = new object();
    public static void AppendAllText(string filename, string text)
    {
        lock(FileInUse)
        {
            File.AppendAllText(filename, text);
        }

    }
}

// Where you can use proxy class
// 01. Load from CacheOrderRepository if exists before loading from database
// 02. Audit Proxies
// 03. Logging and Monitoring 
// 04. 
