using Microsoft.EntityFrameworkCore;

namespace SinemaOtomasyon2.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=..\\..\\files\\SinemaOtomasyon2Db.db");
        }

        public DbSet<Film> Film { get; set; } 
        public DbSet<Seans> Seans { get; set; }
        public DbSet<Rezervasyon> Rezervasyon { get; set; }
    }
}
