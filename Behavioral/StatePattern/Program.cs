using BookingSystem;


var booking = new BookingContext(new GuestUserState(new LogService()));

booking.Login("mehedi","123456");
booking.BookTicket();
booking.Logout();
// booking.CancelBooking();