namespace GerenciadorDeConsultas.Models
{
    public class Procedimento
    {
        public int ProcedimentoID { get; set; }
        public decimal ValorProcedimento { get; set; }
        public int TempoProcedimento { get; set; }
        public string DescricaoProcedimento { get; set; }

        public List<Consulta> Consultas { get; set; }

    }
}
