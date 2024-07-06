namespace BookingSystem;

public interface IBookingSystem
{
    void Login(BookingContext context);
    void BookTicket(BookingContext context);
    void ShowBookings(BookingContext context);
    void CancelBooking(BookingContext context);
    void Logout(BookingContext context);
}