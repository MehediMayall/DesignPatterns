namespace BridgePattern;

public class EmailMessage : IMessage
{
    public Boolean SendMessage(string Recipient, string Message)
    {
        System.Console.WriteLine("\r\n<============= EMAIL ============>");
        Console.WriteLine($"Recipient: {Recipient}\r\nMessage: {Message}\r\nStatus: Email Sent Successfully\r\n");
        return true;
    }
}