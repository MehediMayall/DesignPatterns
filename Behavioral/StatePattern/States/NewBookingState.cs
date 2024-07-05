namespace BookingSystem;

public class NewBookingState : IBookingSystem
{
    private readonly IBookTicketService bookTicketService;
    private readonly ILogService logService;
    private readonly ILogOutService logOutService;
    
    public NewBookingState(IBookTicketService bookTicketService, ILogService logService, ILogOutService logOutService)
    {
        this.logOutService = logOutService;
        this.logService = logService;
        this.bookTicketService = bookTicketService;        
    }


    public void BookTicket(BookingContext context) 
    {
        bookTicketService.BookTicket();
        var logger = new LogService();
        context.SetNextState(new BookedState(new LogOutService(logger), logger, new BookingCancelService(logger)));
    }

    

    public void CancelBooking(BookingContext context) => 
        logService.logError("No booking found");


    public void Login(BookingContext context) =>
        logService.log("You are already logged in");

    public void Logout(BookingContext context)
    {
        logOutService.LogOut();
        var logger = new LogService();
        context.SetNextState(new GuestUserState(new LogInService(logger), logger));
    }

    public void ShowBookings(BookingContext context) => 
        logService.logError("No booking found");

}