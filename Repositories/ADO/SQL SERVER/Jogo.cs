using Microsoft.Data.SqlClient;
using WebApp.Models;

namespace WebApp.Repositories.ADO.SQL_SERVER
{
    public class Jogo
    {
        public Jogo() { }
        public void add(Models.Jogo jogo)
        {
            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SET IDENTITY_INSERT jogo ON " +
                        "insert into jogo (idJogo,timeMandante, timeVisitante,Rodada, resultadoMandante, resultadoVisitante,  statusDoJogo,dataJogo, ImagemMandante, ImagemVisitante) values (@idJogo,@timeMandante,@timeVisitante,@Rodada, @ResultadoMandante, @ResultadoVisitante,  @StatusDoJogo, @dataJogo, @ImagemMandante,@ImagemVisitante);" +
                        "SET IDENTITY_INSERT jogo OFF";
                    command.Parameters.Add(new SqlParameter("@idJogo", System.Data.SqlDbType.Int)).Value = jogo.idJogo;
                    command.Parameters.Add(new SqlParameter("@timeMandante", System.Data.SqlDbType.VarChar)).Value = jogo.timeMandante;
                    command.Parameters.Add(new SqlParameter("@timeVisitante", System.Data.SqlDbType.VarChar)).Value = jogo.timeVisitante;
                    command.Parameters.Add(new SqlParameter("@Rodada", System.Data.SqlDbType.VarChar)).Value = jogo.Rodada;
                    command.Parameters.Add(new SqlParameter("@resultadoMandante", System.Data.SqlDbType.Int)).Value = jogo.resultadoMandante;
                    command.Parameters.Add(new SqlParameter("@resultadoVisitante", System.Data.SqlDbType.Int)).Value = jogo.resultadoVisitante;
                    command.Parameters.Add(new SqlParameter("@statusDoJogo", System.Data.SqlDbType.VarChar)).Value = jogo.statusDoJogo;
                    command.Parameters.Add(new SqlParameter("@dataJogo", System.Data.SqlDbType.Date)).Value = jogo.dataJogo;
                    command.Parameters.Add(new SqlParameter("@ImagemMandante", System.Data.SqlDbType.VarChar)).Value = jogo.ImagemMandante;
                    command.Parameters.Add(new SqlParameter("@ImagemVisitante", System.Data.SqlDbType.VarChar)).Value = jogo.ImagemVisitante;

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Models.Jogo> get()
        {
            List<Models.Jogo> jogos = new List<Models.Jogo>();

            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select idJogo, timeMandante, timeVisitante,Rodada,resultadoMandante,resultadoVisitante,statusDoJogo,dataJogo,ImagemMandante,ImagemVisitante from jogo";
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Models.Jogo jogo = new Models.Jogo();
                        jogo.idJogo = (int)dr["idJogo"];
                        jogo.timeMandante = (string)dr["timeMandante"];
                        jogo.timeVisitante = (string)dr["timeVisitante"];
                        jogo.Rodada = (string)dr["Rodada"];
                        jogo.resultadoMandante = (int)dr["resultadoMandante"];
                        jogo.resultadoVisitante = (int)dr["resultadoVisitante"];
                        jogo.statusDoJogo = (string)dr["statusDoJogo"];
                        jogo.dataJogo = (DateTime)dr["dataJogo"];
                        jogo.ImagemMandante = (string)dr["ImagemMandante"];
                        jogo.ImagemVisitante = (string)dr["ImagemVisitante"];
                        jogos.Add(jogo);

                    }
                }
            }
            return jogos;
        }

        public void delete(int idJogo)
        {
            {
                string connectionString = Configuration.getConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "delete\r\nfrom Jogo\r\nwhere idJogo = @idJogo";
                        command.Parameters.Add(new SqlParameter("@idjogo", System.Data.SqlDbType.Int)).Value = idJogo;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void edit(Models.Jogo jogo)
        {
            {
                string connectionString = Configuration.getConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "update jogo set timeMandante = @timeMandante, timeVisitante = @timeVisitante, Rodada = @Rodada, resultadoMandante =@resultadoMandante, resultadoVisitante = @resultadoVisitante, statusdojogo = @statusdojogo, datajogo = @datajogo, ImagemMandante = @ImagemMandante, ImagemVisitante = @ImagemVisitante  where idJogo = @idjogo";
                        command.Parameters.Add(new SqlParameter("@idJogo", System.Data.SqlDbType.Int)).Value = jogo.idJogo;
                        command.Parameters.Add(new SqlParameter("@timeMandante", System.Data.SqlDbType.VarChar)).Value = jogo.timeMandante;
                        command.Parameters.Add(new SqlParameter("@timeVisitante", System.Data.SqlDbType.VarChar)).Value = jogo.timeVisitante;
                        command.Parameters.Add(new SqlParameter("@Rodada", System.Data.SqlDbType.VarChar)).Value = jogo.Rodada;
                        command.Parameters.Add(new SqlParameter("@resultadoMandante", System.Data.SqlDbType.Int)).Value = jogo.resultadoMandante;
                        command.Parameters.Add(new SqlParameter("@resultadoVisitante", System.Data.SqlDbType.Int)).Value = jogo.resultadoVisitante;
                        command.Parameters.Add(new SqlParameter("@statusDoJogo", System.Data.SqlDbType.VarChar)).Value = jogo.statusDoJogo;
                        command.Parameters.Add(new SqlParameter("@dataJogo", System.Data.SqlDbType.Date)).Value = jogo.dataJogo;
                        command.Parameters.Add(new SqlParameter("@ImagemMandante", System.Data.SqlDbType.VarChar)).Value = jogo.ImagemMandante;
                        command.Parameters.Add(new SqlParameter("@ImagemVisitante", System.Data.SqlDbType.VarChar)).Value = jogo.ImagemVisitante;

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
