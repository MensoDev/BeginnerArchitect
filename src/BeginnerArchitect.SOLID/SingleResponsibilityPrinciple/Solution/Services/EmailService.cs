using System.Net.Mail;

namespace BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.Services;

public class EmailService
{
    public bool Send(string to, string subject, string message)
    {
        try
        {
            var mail = new MailMessage("empresa@empresa.com", to);
            mail.Subject = subject;
            mail.Body = message;
            SendMessage(mail);
            return true;
        }
        catch
        {
            return false;
        }
    }

    private void SendMessage(MailMessage message)
    {
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };
        client.Send(message);

    }
}