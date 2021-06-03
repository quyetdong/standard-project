using Microsoft.EntityFrameworkCore;
using standardProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace standardProject.Data.EF
{
  public class EShopDbContext : DbContext
  {
    public EShopDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
  }
}
