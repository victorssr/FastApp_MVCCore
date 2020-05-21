using Microsoft.EntityFrameworkCore;
using FastApp_MVCCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FastApp_MVCCore.Data
{
    public class ContextBase : IdentityDbContext
    {
        public ContextBase (DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Professor> Professores { get; set; }
    }
}
