using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Violation;

public class Client
{
    public Guid ClientId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Document { get; set; }
    public DateTime RegistrationDate { get; set; }

    public string AddClient()
    {
        if (!Email.Contains("@"))
            return "Client with invalid e-mail.";

        if (Document.Length != 11)
            return "Client with invalid Document";


        using (var cn = new SqlConnection())
        {
            var cmd = new SqlCommand();

            cn.ConnectionString = "MyConnectionString";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

            cmd.Parameters.AddWithValue("nome", Name);
            cmd.Parameters.AddWithValue("email", Email);
            cmd.Parameters.AddWithValue("cpf", Document);
            cmd.Parameters.AddWithValue("dataCad", RegistrationDate);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        var mail = new MailMessage("empresa@empresa.com", Email);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Bem Vindo.";
        mail.Body = "Parabéns! Você está cadastrado.";
        client.Send(mail);

        return "Cliente cadastrado com sucesso!";
    }
}