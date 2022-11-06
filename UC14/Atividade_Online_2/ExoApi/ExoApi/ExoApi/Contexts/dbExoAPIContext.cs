using Microsoft.EntityFrameworkCore;
using ExoApi.Models;

namespace ExoApi.Contexts
{
    public class dbExoAPIContext: DbContext
    {
        public dbExoAPIContext()
        {
        }
        public dbExoAPIContext(DbContextOptions<dbExoAPIContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-R4IJFCJ\\SQLEXPRESS; initial catalog = dbExoAPI; User Id = sa; Password = Admin123");
            }
        }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
