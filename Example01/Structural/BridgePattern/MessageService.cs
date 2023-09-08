namespace BridgePattern;

public class MessageService : IMessageService
{
    private IMessage message;
    private MessageTypes MessageType;


    public MessageService(MessageTypes MessageType)
    {
        this.MessageType = MessageType;
    }

    
    public Boolean SendMessage(string Recipient, string Message)
    {
        this.message = this.MessageType switch
        {
            MessageTypes.EMAIL => new EmailMessage(),
            MessageTypes.SMS => new SMSMessage()
        };

        this.message.SendMessage(Recipient, Message);
        return true;
    }

    public Boolean SendMessage(MessageTypes MessageType, string Recipient, string Message)
    {
        this.MessageType = MessageType;
        return this.SendMessage(Recipient, Message);        
    }

}