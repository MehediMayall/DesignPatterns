using BookingSystem;
using static System.Console;

var logger = new LogService();
var loginService = new LogInService();

var booking = new BookingContext(new GuestUserState(loginService, logger));

int userSelectionNo = 9;
while (userSelectionNo > 0)
{
    Console.ForegroundColor = ConsoleColor.White;

    Write("""
        1: Login
        2: New Booking
        3: Show Result
        4: Cancel Ticket
        5: Logout
        Enter your choice:
    """);
    userSelectionNo =  int.Parse(ReadLine());
    WriteLine("\n");

    switch (userSelectionNo)
    {
        case 1: booking.Login();break;
        case 2: booking.BookTicket();break;
        case 3: booking.ShowBookings();break;
        case 4: booking.CancelBooking();break;
        case 5: booking.Logout();break;
        default : WriteLine("\nInvalid selection\n");break;
    };

    WriteLine("\n");
}


