﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace standardProject.Data.EF
{
  public class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
  {
    public EShopDbContext CreateDbContext(string[] args)
    {
      // Build config
      IConfiguration configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();
      var connectionString = configuration.GetConnectionString("eShopProjectDb");

      var optionsBuilder = new DbContextOptionsBuilder<EShopDbContext>();
      optionsBuilder.UseSqlServer(connectionString);

      return new EShopDbContext(optionsBuilder.Options);
    }
  }
}
