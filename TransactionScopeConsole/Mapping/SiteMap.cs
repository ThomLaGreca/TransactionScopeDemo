using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionScopeConsole.Model;

namespace TransactionScopeConsole.Mapping
{
  public class SiteMap : IEntityTypeConfiguration<Site>
  {
    public void Configure(EntityTypeBuilder<Site> builder)
    {
      builder.ToTable(nameof(Site));
      builder.HasKey(t => t.SiteId);
    }
  }
}
