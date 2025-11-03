using CarDealer.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Infrastructure.Data
{
    public class CarDealerDbContext : DbContext
    {
        public CarDealerDbContext(DbContextOptions<CarDealerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Inquiry> Inquiries { get; set; } // <- добавь эту строку

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(c => c.Price)
                    .HasPrecision(18, 2);
            });

            // Настройка для Inquiry, если нужна
            modelBuilder.Entity<Inquiry>(entity =>
            {
                entity.Property(i => i.Name).IsRequired().HasMaxLength(100);
                entity.Property(i => i.Email).IsRequired().HasMaxLength(100);
                entity.Property(i => i.Message).IsRequired();
            });
        }
    }
}