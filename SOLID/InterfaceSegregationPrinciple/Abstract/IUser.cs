namespace InterfaceSegregationPrinciple;

// public interface IUser
// {
//     bool Login(string UserName, string Password);
//     bool Register(string UserName, string Email, string Password);
//     void Log(string Message);
//     void SendEmail(string Subject, string Content);
// }

/*
    ||
    ||
    \/
*/

public interface IUser
{
    bool Login(string UserName, string Password);
    bool Register(string UserName, string Email, string Password);
}

public interface ILogger
{
    void Log(string Message);
}

public interface IEmailService
{
    void SendEmail(string Subject, string Content);
}