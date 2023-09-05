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