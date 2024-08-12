
// Write some text to the same file parallely will result wrong output
// Parallel.For(0,10, i => File.AppendAllText("file.txt", $"{i}, "));
string filename = "file.txt";
File.Delete(filename);


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