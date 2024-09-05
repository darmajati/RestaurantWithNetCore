using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .ToTable("customers")
                .HasKey(c => c.customer_id);

            modelBuilder.Entity<Food>()
                .ToTable("foods")
                .HasKey(f => f.food_id);

            modelBuilder.Entity<Transaction>()
                .ToTable("transactions")
                .HasKey(t => t.transaction_id);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Customer)
                .WithMany(c => c.Transactions)
                .HasForeignKey(t => t.customer_id);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Food)
                .WithMany(f => f.Transactions)
                .HasForeignKey(t => t.food_id);
        }
    }

}