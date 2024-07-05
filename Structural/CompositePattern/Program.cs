using CompositePattern;


public class Program
{
    private static void Main(string[] args)
    {
       var root = new Composite("Root");
       root.Add(new Leaf("Leaf A"));
       root.Add(new Leaf("Leaf B"));

       var composite1 = new Composite("Composite 1");
       composite1.Add(new Leaf("Leaf C1-A"));
       composite1.Add(new Leaf("Leaf C1-B"));

       var composite2 = new Composite("Composite 2");
       composite2.Add(new Leaf("Leaf C2-A"));
       composite2.Add(new Leaf("Leaf C2-B"));

       composite1.Add(composite2);

       root.Add(composite1);
       root.Add(new Leaf("Leaf C"));

       var leaf = new Leaf("Leaf D");

       root.PrintNode(1);
    }
}