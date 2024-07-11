namespace ObserverPattern;

public class HospitalStation : IObserver<Alarm>
{
    public void Alert(Alarm alarm)
    {
        Console.WriteLine($"Hospital station is coming.");
    }
}