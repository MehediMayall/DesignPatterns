namespace BridgePattern;

public interface IMessageService
{
    Boolean SendMessage(string Recipient, string Message); 
    Boolean SendMessage(MessageTypes MessageType, string Recipient, string Message);   
}