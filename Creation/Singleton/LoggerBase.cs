namespace Singleton;

public class LoggerBase
{
    private static LoggerBase instance;
    public static LoggerBase Instance { 
        get { 
            if (instance == null) instance = new LoggerBase();
            return instance;
          }
    }
    protected LoggerBase()
    {
        print("Logger Base Constructor is being called");
    }

    public void print(object message) => Console.WriteLine(message);
}