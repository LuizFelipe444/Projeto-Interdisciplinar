using Microsoft.Data.SqlClient;
using WebApp.Models;
using WebApp.Repositories;

namespace web_app.Repositories.ADO.SQLServer
{
    public class Login
    {
        private readonly string connectionString;
        public Login(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool check(Models.Login login)
        {
            bool result = false;

            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id from login where usuario=@usuario and senha=@senha";
                    command.Parameters.Add(new SqlParameter("@usuario", System.Data.SqlDbType.VarChar)).Value = login.usuario;
                    command.Parameters.Add(new SqlParameter("@senha", System.Data.SqlDbType.VarChar)).Value = login.senha;

                    SqlDataReader dr = command.ExecuteReader();
                    result = dr.Read();
                }
            }

            return result;
        }
        public void add(Models.Login login)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SET IDENTITY_INSERT login ON insert into login (id,usuario,senha) values (@id,@usuario,@senha) SET IDENTITY_INSERT login OFF";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = login.id;
                    command.Parameters.Add(new SqlParameter("@usuario", System.Data.SqlDbType.VarChar)).Value = login.usuario;
                    command.Parameters.Add(new SqlParameter("@senha", System.Data.SqlDbType.Char)).Value = login.senha;


                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
