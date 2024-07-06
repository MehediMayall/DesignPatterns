namespace BookingSystem;

public class LogOutService: ILogOutService
{
    private readonly ILogService logService;

    public LogOutService(ILogService logService)
    {
        this.logService = logService;
    }
    public void LogOut()
    {
        logService.log("|<- Successfully logout.");
    }
}