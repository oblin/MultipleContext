using System;
using Microsoft.EntityFrameworkCore;

namespace MultipleContext.Sales
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Sales");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Order>(options =>
            {
                options.OwnsOne(p => p.Address);
            });
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
        }
    }
}
