using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Data;
using System.Reflection.Emit;

namespace WebProje.Models
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }


        public DbSet<Login> Login { get; set; }
        public DbSet<ModelSahiplen> ModelSahiplen { get; set; }

        public DbSet<ModelHayvanKabul> modelHayvanKabul { get; set; }

    }
}
