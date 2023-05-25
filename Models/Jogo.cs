namespace WebApp.Models
{
    public class Jogo
    {
        public int idJogo { get; set; }
        public string timeMandante { get; set; }
        public string timeVisitante { get; set; }
        public string Rodada { get; set; }
        public int resultadoMandante { get; set; }
        public int resultadoVisitante { get; set; }
        public string statusDoJogo { get; set; }
        public string detalhes { get; set; }
        public DateTime dataJogo { get; set; }


        public Jogo()
        {
            this.idJogo = 0;
            this.timeMandante = string.Empty;
            this.timeVisitante = string.Empty;
            this.Rodada = string.Empty;
            this.resultadoMandante = 0;
            this.resultadoVisitante = 0;
            this.statusDoJogo = string.Empty;
            this.detalhes = string.Empty;
            this.dataJogo = DateTime.Now;
        }
    }
}