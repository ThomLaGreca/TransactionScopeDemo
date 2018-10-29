using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TransactionScopeConsole.Mapping;
using TransactionScopeConsole.Model;

namespace TransactionScopeConsole
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<Site> Sites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=localhost;Database=TransactionScopeDemo;Trusted_Connection=True;Integrated Security=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfiguration(new DeliveryMap());
      modelBuilder.ApplyConfiguration(new SiteMap());
    }
  }
}
