namespace CompositePattern;

public class Leaf : Component
{
    public Leaf(string Name): base(Name)
    {
        
    }

    public override void PrintNode(int Depth)
    {
        System.Console.WriteLine(new String(' ',Depth) + this.Name);
    }
   
}