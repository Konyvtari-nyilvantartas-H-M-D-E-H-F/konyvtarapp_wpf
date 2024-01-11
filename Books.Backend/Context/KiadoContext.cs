using Books.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Context
{
    public class KiadokContext : DbContext
    {
        public DbSet<Kiado> Kiadok { get; set; }

        public KiadokContext(DbContextOptions<KiadokContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
