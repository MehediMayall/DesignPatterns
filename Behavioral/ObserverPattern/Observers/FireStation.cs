namespace ObserverPattern;

public class FireStation : IObserver<Alarm>
{
    public void Alert(Alarm alarm)
    {
        Console.WriteLine("Fire station is coming.");
    }
}
