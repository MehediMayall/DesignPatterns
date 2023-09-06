/*
Adapter is a structural design pattern that allows objects with incompatible interfaces
to collaborate.

Adapter is also known as Wrapper.
An Adapter allows two incompatible interfaces to work together. Inteface may be incompatible, but the inner functionality should
suit the need.

The adapter design pattern allows incompatible classed to work together by converting the interface of a class into an 
interface expected by the clients.

*/



using AdapterPattern;

IPlayer player = new PlayerAdapter();

var externalPlayer = new PlayerFromExternal{
    Fullname = "Sakib Al Hasan",
    CountryCode = "BD",
    Age=36
};

player.AddPlayer(externalPlayer);

foreach (var item in player.GetAll())
{
    Console.WriteLine($"FirstName: {item.FirstName}, LastName: {item.LastName}, Country: {item.CountryName}, DateOfBirth: {item.BirthDate}");
}