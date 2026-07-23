using System;
using Microsoft.EntityFrameworkCore;
using CRM.Api.Models;

namespace CRM.Api.Data
{
    public class CrmDbContext : DbContext
    {
        public CrmDbContext(DbContextOptions<CrmDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // If no options were provided, attempt to configure SQL Server from environment.
                // Expect a connection string in the environment variable: ConnectionStrings__CrmDatabase
                var conn = Environment.GetEnvironmentVariable("CrmDatabase");
                if (!string.IsNullOrEmpty(conn))
                {
                    optionsBuilder.UseSqlServer(conn);
                }
            }
        }
    }
}
