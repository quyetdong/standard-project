using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using standardProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace standardProject.Data.Configurations
{
  public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
  {
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
      builder.ToTable("OrderDetails");
      builder.HasKey(x => new { x.OrderId, x.ProductId });

      builder.HasOne(x => x.Order).WithMany(or => or.OrderDetails)
        .HasForeignKey(x => x.OrderId);
      builder.HasOne(x => x.Product).WithMany(p => p.OrderDetails)
        .HasForeignKey(x => x.ProductId);
    }
  }
}
