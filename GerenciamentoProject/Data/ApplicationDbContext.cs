using GerenciamentoProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<DescontosModel> Descontos { get; set; }
       
    }
}
