using System.Reflection;

namespace Route_Groups_AspNet.Model;

public class Category(string title, string url)
{
    private static int Counter;

    public Guid? Id { get; private set; } = Guid.NewGuid();
    public string Title { get; private set; } = title;
    public string Url { get; private  set; } = url;

}