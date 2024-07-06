namespace BookingSystem;

public class GuestUserState : IBookingSystem
{
    private readonly ILogService logService;
    private readonly ILogInService logInService;
    public GuestUserState(ILogInService logInService, ILogService logService)
    {
        this.logInService = logInService;
        this.logService = logService;        
    }

    public void BookTicket(BookingContext context) => logService.logError("Please login first");
    

    public void CancelBooking(BookingContext context) => logService.logError("Please login first");


    public void Login(BookingContext context)
    {
        logInService.LogIn();

        // Next State
        var logger = new LogService();
        var LogoutService = new LogOutService();        
        context.SetNextState(new NewBookingState(new BookTicketService(),logger, LogoutService));
    }

    public void Logout(BookingContext context) => logService.logError("Please login first");

    public void ShowBookings(BookingContext context) => logService.logError("Please login first");

}