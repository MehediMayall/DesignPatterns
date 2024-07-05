namespace BookingSystem;

public class GuestUserState : IBookingSystem
{
    private readonly ILogService logService;
    public GuestUserState(ILogService logService)
    {
        this.logService = logService;
        
    }

    public void BookTicket(BookingContext context) => logService.logError("Please login first");
    

    public void CancelBooking(BookingContext context) => logService.logError("Please login first");


    public void Login(BookingContext context, string username, string password)
    {
        logService.log("->| Login successfully");
        var logger = new LogService();
        var LogoutService = new LogOutService(logger);
        context.SetNextState(new NewBookingState(new BookTicketService( logger),logger, LogoutService));
    }

    public void Logout(BookingContext context) => logService.logError("Please login first");

    public void ShowBookings(BookingContext context) => logService.logError("Please login first");

}