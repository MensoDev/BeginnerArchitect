using BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.Entities;
using BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.Repository;

namespace BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.Services;

public class ClientService
{
    public bool RegisterClient(Client client)
    {
        client.Validate();

        var mailService = new EmailService();
        var repository = new ClientRepository();

        repository.AddClient(client);
        mailService.Send(client.Email.Address, "Welcome to", "Nice to mete you");

        return true;
    }

}