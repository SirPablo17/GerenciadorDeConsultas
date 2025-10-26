using Microsoft.EntityFrameworkCore; // Need this line!
using GerenciadorDeConsultas.Models; // And this one for your models

namespace GerenciadorDeConsultas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
    }
}
