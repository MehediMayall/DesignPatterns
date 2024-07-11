namespace ObserverPattern;

public class PoliceStation : IObserver<Alarm>
{
    public void Alert(Alarm alarm)
    {
        Console.WriteLine("Police station is coming.");
    }
}
