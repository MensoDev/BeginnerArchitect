namespace BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.ValueObjects;

public class Email
{
    public Email(string address)
    {
        Address = address;
        
        Validate();
    }

    public string Address { get; private set; }

    public void Validate()
    {
        if (Address == string.Empty) throw new ArgumentException();
    }
}