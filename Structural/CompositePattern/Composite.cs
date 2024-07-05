namespace CompositePattern;

public class Composite : Component
{

    private List<Component> children = new List<Component>();

    public Composite(string Name) : base(Name)
    {
        
    }
    public void Add(Component component)
    {
        children.Add(component);
    }

    public override void PrintNode(int Depth)
    {
        System.Console.WriteLine(new String(' ',Depth) + this.Name);
        foreach (Component child in children)
        {
            child.PrintNode(Depth + 2);
        }
    }

    public void Remove(Component component)
    {
        children.Remove(component);
    }
}