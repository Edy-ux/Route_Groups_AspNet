using System.Reflection;

namespace Route_Groups_AspNet.Dtos;

public class Category
{
    private static int Counter;
    public Guid? Id { get; private set; }
    public string Name { get; set; }
    public string Description { get;  set; }
    
    public Category()
    {
        Id = Guid.NewGuid();    
        Counter++;  
        Console.WriteLine($"Created Category {Counter} {Name}");
    }

}