using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoverCard.Api.Models;

namespace CoverCard.Api.Data
{
    public class AppDbContext : IdentityDbContext<Broker>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
    }
}