namespace BuilderPattern;

public interface IDatabaseBuilder
{
    public IDatabase Database { get;}
    void BuildConnection();
    void BuildCommand();
    void SetSettings();
}
