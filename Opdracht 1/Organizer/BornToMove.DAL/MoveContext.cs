
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BornToMove;

namespace BornToMove.DAL
{


    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<MoveContext>();
        
    }
    public class MoveContext : DbContext
    {
        public DbSet<Move> Moves { get; set; }
        public DbSet<MoveRating> MoveRating { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoveRating>().ToTable("MoveRating");
            modelBuilder.Entity<Move>().ToTable("move");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          var serverVersion = new MariaDbServerVersion(new Version(10, 4, 27));
         optionsBuilder.UseMySql("Server=localhost;Database=born2move;Uid=root;Pwd=Edu-Com17;", serverVersion);
          
            
        }

       
        
    }
}
