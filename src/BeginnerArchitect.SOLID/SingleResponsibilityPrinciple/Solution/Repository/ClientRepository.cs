using System.Data;
using System.Data.SqlClient;
using BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.Entities;

namespace BeginnerArchitect.SOLID.SingleResponsibilityPrinciple.Solution.Repository;

public class ClientRepository
{
    public void AddClient(Client client)
    {
        using (var cn = new SqlConnection())
        {
            var cmd = new SqlCommand();

            cn.ConnectionString = "MyConnectionString";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

            cmd.Parameters.AddWithValue("nome", client.Name.ToString());
            cmd.Parameters.AddWithValue("email", client.Email.Address);
            cmd.Parameters.AddWithValue("cpf", client.Document.NormalizedNumber);
            cmd.Parameters.AddWithValue("dataCad", client.RegistrationDate);

            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}