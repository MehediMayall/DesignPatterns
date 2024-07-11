namespace ObserverPattern;

public class Alarm
{
    List<IObserver<Alarm>> observers = new();
    public void AddWatcher(IObserver<Alarm> observer) =>
        observers.Add(observer);

    public void Notify()
    {
        foreach(var observer in observers)
            observer.Alert(this);
    }

    ~Alarm()
    {
        System.Console.WriteLine("Alarm class is being destructed");
    }
}