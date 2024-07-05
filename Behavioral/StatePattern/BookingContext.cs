namespace BookingSystem;

public class BookingContext
{
    private IBookingSystem bookingState;

    public BookingContext(IBookingSystem bookingSystem)
    {
        bookingState = bookingSystem;
    }

    public void SetNextState(IBookingSystem state) => 
        this.bookingState = state;

    public void Login(string UserName, string Password) => 
        this.bookingState.Login(this, UserName,Password);

    public void BookTicket() => bookingState.BookTicket(this);
    public void ShowBookings() => bookingState.ShowBookings(this);
    public void CancelBooking() => bookingState.CancelBooking(this);
    public void Logout() => bookingState.Logout(this);

}