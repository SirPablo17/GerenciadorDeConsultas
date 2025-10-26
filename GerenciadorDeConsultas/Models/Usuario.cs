namespace GerenciadorDeConsultas.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; } 
        public string RoleUsuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; } 
        public string Endereco { get; set; }
        public string NumeroCasa { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string Cep { get; set; }
        public string TelefoneUsuario { get; set; }
        public bool UsuarioAtivoInativo { get; set; }
        public DateOnly DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public int QuantidadeTentativas { get; set; }
    }
}