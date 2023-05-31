namespace web_app.Models
{
    public class Login
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }

        public Login()
        {
            this.id = 0;   
            this.usuario = string.Empty;
            this.senha = string.Empty;
        }
    }
}

