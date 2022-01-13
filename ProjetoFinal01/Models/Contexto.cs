using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal01.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
    }
}
