namespace AdapterPattern;

public class PlayerAdapter: IPlayer
{
    private List<Player> Players = null;

    public Player AddPlayer(PlayerFromExternal player)
    {
        if (Players == null) this.Players = new List<Player>();
        string[] names = player.Fullname.Split(' ');
        (string FirstName, string LastName) = (names[0], names[names.Length-1]);

        var newPlayer = new Player{
                FirstName = FirstName,
                LastName = LastName,
                CountryName = player.CountryCode,
                BirthDate = DateTime.Now.AddYears(-player.Age)
            };

        this.Players.Add(newPlayer);

        return newPlayer;
    }

    public List<Player> GetAll()
    {
        return this.Players;
    }
}