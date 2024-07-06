using BookingSystem;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static System.Console;

IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddSingleton<ILogInService, LogInService>();
    services.AddSingleton<ILogService, LogService>();
}).Build();


// var logger = new LogService();
// var loginService = new LogInService();

var booking = new BookingContext(new GuestUserState(host.Services.GetRequiredService<ILogInService>(), host.Services.GetRequiredService<ILogService>()));

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


