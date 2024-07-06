namespace BookingSystem;

public class BookingDisplayService: BaseService, IBookingDisplayService
{
   

    public BookingDisplayService()
    {
 
    }
    public void ShowBookings()
    {
        log("Here is your booking");
    }

    
}