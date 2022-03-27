namespace BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.ValueObjects;

public class Name
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        
        Validate();
    }

    public string FirstName { get; private set; }  
    public string LastName { get; private set; }

    public void Validate()
    {
        if (FirstName == string.Empty) throw new ArgumentException();
        if (LastName == string.Empty) throw new ArgumentException();
    }
}