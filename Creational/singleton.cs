namespace Singleton;

public class Logger
{
    private static Logger instance;
    private Logger()
    {

    }

    public static Logger GetInstance()
    {
        if(instance is null)
        {
            return instance = new Logger();
        }
        else return instance;
    }

    public void Log(string message)
    {
        System.Console.WriteLine(message);
    }
}