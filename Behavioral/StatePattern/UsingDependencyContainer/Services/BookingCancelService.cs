namespace BookingSystem;

public class BookingCancelService: BaseService, IBookingCancelService
{
   

    public BookingCancelService()
    {
 
    }
    public void CancelBooking()
    {
        log("Successfully cancelled booking");
    }
}