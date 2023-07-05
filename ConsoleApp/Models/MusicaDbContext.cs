using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Models
{
    public class MusicaDbContext : DbContext
    {
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Cancion> Cancion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MusicaDB;Trusted_Connection=true;");
        }
    }
}
