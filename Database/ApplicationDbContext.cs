using Cadastro_de_CEPs.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_de_CEPs.Database {
    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }

        public DbSet<Endereco> Enderecos { get; set; }

    }
}