using Microsoft.EntityFrameworkCore;

namespace Agencia.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Destino> Destino { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
