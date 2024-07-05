namespace CompositePattern;

public  abstract class Component
{
    public Component(string Name)
    {
        this.Name = Name;
    }
    
    public string Name { get; set; }

   
    public abstract void PrintNode(int Depth);

}