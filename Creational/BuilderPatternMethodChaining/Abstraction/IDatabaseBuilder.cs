namespace BuilderPattern;

public interface IDatabaseBuilder
{
    IDatabaseBuilder BuildConnection();
    IDatabaseBuilder BuildCommand();
    IDatabaseBuilder SetSettings(int Timeout=360, CommandType commandType = CommandType.Text);
    IDatabase Build();
}
