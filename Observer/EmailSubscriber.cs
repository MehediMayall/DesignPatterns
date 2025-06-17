namespace ObserverPattern;

public interface IEmailSubscriber
{
    string Email { get; init; }
    Task Notify(string Content);
}


public sealed class EmailSubscriber : IEmailSubscriber
{

    public string Email { get; init; } = "";
    public EmailSubscriber(string Email) => this.Email = Email;

    public async Task Notify(string Content) =>
        Console.WriteLine($"An email has been sent to {Email}. Content: {Content}");
}


