using BookingSystem;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static System.Console;

IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddSingleton<ILogService, LogService>();

    services.AddSingleton<ILogInService, LogInService>();
    services.AddSingleton<ILogOutService, LogOutService>();

    services.AddSingleton<IBookTicketService, BookTicketService>();
    services.AddSingleton<IBookingCancelService, BookingCancelService>();
    services.AddSingleton<IBookingDisplayService, BookingDisplayService>();

     
    services.AddTransient<IBookingSystem, GuestUserState>();
    services.AddTransient<IBookingSystem, NewBookingState>();
    services.AddTransient<IBookingSystem, BookedState>();

    // services.AddTransient<BookingContext>();

}).Build();


var guestUser = host.Services.GetRequiredService<GuestUserState>();
var booking = new BookingContext(guestUser);

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
    userSelectionNo =  int.Parse(Console.ReadLine());
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


