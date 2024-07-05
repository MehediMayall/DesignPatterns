namespace BookingSystem;

public class BookingCancelService: IBookingCancelService
{
    private readonly ILogService logService;

    public BookingCancelService(ILogService logService)
    {
        this.logService = logService;
    }
    public void CancelBooking()
    {
        logService.log("Successfully cancelled booking");
    }
}