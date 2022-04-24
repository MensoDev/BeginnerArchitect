using static System.Console;

namespace BeginnerArchitect.DesignPatterns.Creational.SingletonPattern;

public class Singleton
{
    private static Singleton? _singleton;
    private readonly Guid _instanceId;

    private Singleton()
    {
        WriteLine("Creating Instance of Singleton....");
        _instanceId = Guid.NewGuid();
        WriteLine($"Created Instance of Singleton === {_instanceId}");
    }

    public static Singleton Instance => _singleton ??= new Singleton();

    public void ShowGuid()
    {
        WriteLine($"Instance Id: {_instanceId}");
    }
}