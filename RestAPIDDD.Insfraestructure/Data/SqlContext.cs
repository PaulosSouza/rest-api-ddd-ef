using Microsoft.EntityFrameworkCore;
using RestAPIDDD.Domain;
using System;
using System.Linq;

namespace RestAPIDDD.Infrastructure
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public override int SaveChanges()
        {
            string createdAtEntry = "CreatedAt";

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty(createdAtEntry) != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(createdAtEntry).CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property(createdAtEntry).IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}