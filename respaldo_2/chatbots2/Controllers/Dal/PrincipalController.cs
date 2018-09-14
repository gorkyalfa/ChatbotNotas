using System.Data.Entity;

namespace NotasRazorr.Dal
{
    public class Principal : DbContext
    {
        public DbSet<Pregunta> Preguntas { get; set; }
    }
}
