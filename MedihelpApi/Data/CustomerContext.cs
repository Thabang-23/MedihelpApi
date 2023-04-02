using MedihelpApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MedihelpApi.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CustomerName).HasMaxLength(50);
                entity.Property(e => e.ChosenPlan).HasMaxLength(50);
            });
        }
    }
}