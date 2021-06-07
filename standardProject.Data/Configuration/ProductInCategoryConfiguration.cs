using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using standardProject.Data.Entities;
using standardProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace standardProject.Data.Configurations
{
  public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
  {
    public void Configure(EntityTypeBuilder<ProductInCategory> builder)
    {
      builder.ToTable("ProductInCategories");
      builder.HasKey(x => new { x.ProductId, x.CategoryId });

      builder.HasOne(x => x.Product).WithMany(p => p.ProductInCategories)
        .HasForeignKey(x => x.ProductId);
      builder.HasOne(x => x.Category).WithMany(p => p.ProductInCategories)
        .HasForeignKey(x => x.CategoryId);
    }
  }
}
