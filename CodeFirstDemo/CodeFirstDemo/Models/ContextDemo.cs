using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CodeFirstDemo.Models
{
    public class ContextDemo : DbContext
    {
        public ContextDemo(DbContextOptions<ContextDemo> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerInstrument> PlayerInstruments { get; set; }

        public DbSet<InstrumentType> InstrumentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>().HasMany(p => p.Instruments).WithOne();

            modelBuilder.Seed();
        }
    }

    public static class DbSeeder
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstrumentType>().HasData(
                new InstrumentType { InstrumentTypeId = 1, InstrumentName = "guitar" },
                new InstrumentType { InstrumentTypeId = 2, InstrumentName = "guitar1" },
                new InstrumentType { InstrumentTypeId = 3, InstrumentName = "guitar2" },
                new InstrumentType { InstrumentTypeId = 4, InstrumentName = "guitar3" },
                new InstrumentType { InstrumentTypeId = 5, InstrumentName = "guitar4" });
        }
    }

    public static class DbServiceExtension
    {
        public static void AddDatabaseService(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ContextDemo>(options => options.UseSqlServer(connectionString));
        }
    }
}


