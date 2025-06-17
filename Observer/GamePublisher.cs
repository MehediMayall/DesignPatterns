namespace ObserverPattern;


public sealed class GamePublisher
{
    private readonly List<IEmailSubscriber> _subcribers = new();

    public void Subscribe(IEmailSubscriber subscriber) =>
        _subcribers.Add(subscriber);

    public void UnSubcribe(IEmailSubscriber subscriber)
    {

        var deleteSubscriber = _subcribers.FirstOrDefault(s => s.Email == subscriber.Email);
        if (deleteSubscriber != default)
            _subcribers.Remove(deleteSubscriber);
        else
            Console.WriteLine($"Not found: {subscriber.Email}");
    }


    public void ReleaseGame(string GameName)
    {
        Console.WriteLine($"Game Released: {GameName}");
        string content = $"Hey Gamer, {GameName} has been released today. ";

        foreach (var subscriber in _subcribers)
            subscriber.Notify(content);
    }

}