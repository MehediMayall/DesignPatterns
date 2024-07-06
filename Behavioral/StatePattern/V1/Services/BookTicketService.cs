namespace BookingSystem;

public class BookTicketService(ILogService logService) : IBookTicketService
{
    public void BookTicket()
    {
        logService.log("Succesffully booked");
    }

    
}