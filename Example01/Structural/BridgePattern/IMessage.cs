namespace BridgePattern;


public interface IMessage
{
    Boolean SendMessage(string Recipient, string Message);
}