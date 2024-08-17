namespace BuilderPattern;

public class MyUriBuilder
{
    public int Port { get; set; }
    public string Protocol { get; set; }
    public string Host { get; set; }
    public string Path { get; set; }
    public string Query { get; set; }


    public MyUriBuilder(string uri="")
    {
        
    }
    public MyUriBuilder(string host)
    {
        
    }



}