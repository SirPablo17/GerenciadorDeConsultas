namespace GerenciadorDeConsultas.Models
{
    public class Consulta
    {
        public int ConsultaID { get; set; }
        public decimal ValorConsulta { get; set; }
        public DateTime DataConsulta { get; set; }
        public bool ConsultaConfirmada { get; set; }

        // Relacionamento com Usuario (uma Consulta tem um Usuario)
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        // Relacionamento com Procedimento (uma Consulta tem muitos Procedimentos)
        public List<Procedimento> Procedimentos { get; set; }
    }
}