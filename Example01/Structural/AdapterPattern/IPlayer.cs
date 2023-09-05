namespace AdapterPattern;

public interface IPlayer
{
    Player AddPlayer(PlayerFromExternal player);
    List<Player> GetAll();
}