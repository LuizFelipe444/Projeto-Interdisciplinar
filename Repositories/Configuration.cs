namespace WebApp.Repositories
{
    public static class Configuration
    {
        public static string getConnectionString()
        {
            return "Server=LAB03-D20\\SQLEXPRESS;Database=CadastroJogos; Trusted_Connection = True; TrustServerCertificate=True;";
        } 
    }
}
