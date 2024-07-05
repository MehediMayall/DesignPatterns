namespace BookingSystem;

public class BookedState : IBookingSystem
{
    private readonly ILogService logService;
    private readonly ILogOutService logOutService;

    public BookedState(ILogOutService logOutService, ILogService logService)
    {
        this.logService = logService;
        this.logOutService = logOutService;
    }

    public void BookTicket(BookingContext context) 
    {
        logService.log("Successfully booked ticket");
        
    }



    public void CancelBooking(BookingContext context) => 
        logService.logError("No booking found");


    public void Login(BookingContext context, string username, string password) =>
        logService.log("You are already logged in");

    public void Logout(BookingContext context) => 
        logOutService.LogOut();

    public void ShowBookings(BookingContext context) => logService.logError("No booking found");

}