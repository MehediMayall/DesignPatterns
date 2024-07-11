namespace ObserverPattern;

public interface IObserver<T>
{
    void Alert(Alarm alarm);
}
