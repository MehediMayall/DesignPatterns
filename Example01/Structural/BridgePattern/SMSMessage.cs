namespace BridgePattern;

public class SMSMessage: IMessage
{
    public Boolean SendMessage(string Recipient, string Message)
    {
        Console.WriteLine("\r\n<============= SMS ============>");
        Console.WriteLine($"Recipient: {Recipient}\r\nMessage: {Message}\r\nStatus: SMS Sent Successfully\r\n");
        return true;
    }
}