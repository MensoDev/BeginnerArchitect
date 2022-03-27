namespace BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.ValueObjects;

public class Document
{
    public Document(string number, string normalizedNumber)
    {
        Number = number;
        NormalizedNumber = normalizedNumber;
    }

    public string Number { get; private set; }
    public string NormalizedNumber { get; private set; }

    public void Validate()
    {
        if (Number is "") throw new ArgumentException();
        if (NormalizedNumber is "") throw new ArgumentException();
    }
}