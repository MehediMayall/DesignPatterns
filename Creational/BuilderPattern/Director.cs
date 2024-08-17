namespace BuilderPattern;

public class Director
{
    public static void Build(IDatabaseBuilder builder)
    {
        builder.BuildConnection();
        builder.BuildCommand();
        builder.SetSettings();
    }
}