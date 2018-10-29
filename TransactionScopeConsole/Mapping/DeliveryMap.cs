using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TransactionScopeConsole.Model;

namespace TransactionScopeConsole.Mapping
{
  public class DeliveryMap : IEntityTypeConfiguration<Delivery>
  {
    public void Configure(EntityTypeBuilder<Delivery> builder)
    {
      
      builder.ToTable(nameof(Delivery));
      builder.HasKey(t => t.DeliveryId);
    }
  }
}
