using BeginnerArchitect.DesignPatterns.Creational.SingletonPattern;

namespace BeginnerArchitect.DesignPatterns.Creational;

public class SingletonClient : ILaboratoryRun
{
    public void Run()
    {
        WriteLine("Creating Instance S1");
        var singleton1 = Singleton.Instance;
        
        WriteLine("Created Instance S1");
        singleton1.ShowGuid();
        singleton1.ShowGuid();
        singleton1.ShowGuid();
        
        WriteLine("\n\nCreating Instance S2");
        var singleton2 = Singleton.Instance;
        
        WriteLine("Created Instance S2");
        singleton2.ShowGuid();
        singleton2.ShowGuid();
        singleton2.ShowGuid();
    }
}