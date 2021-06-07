﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using standardProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace standardProject.Data.Configurations
{
  public class OrderConfiguration : IEntityTypeConfiguration<Order>
  {
    public void Configure(EntityTypeBuilder<Order> builder)
    {
      builder.ToTable("Orders");
      builder.HasKey(x => x.Id);

    }
  }
}
