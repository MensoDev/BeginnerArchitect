using BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.ValueObjects;

namespace BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.Entities;

public class Client
{
    public Client(Name name, Email email, Document document, DateTime registrationDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Document = document;
        RegistrationDate = registrationDate;
        
        Validate();
    }

    public Guid Id { get; private set; }
    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public Document Document { get; private set; }
    public DateTime RegistrationDate { get; private set; }

    public void Validate()
    {
        if (Id == Guid.Empty) throw new ArgumentException();
    }
}