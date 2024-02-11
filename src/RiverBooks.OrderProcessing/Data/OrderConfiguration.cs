﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiverBooks.OrderProcessing.Domain;

namespace RiverBooks.OrderProcessing.Data;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
  void IEntityTypeConfiguration<Order>.Configure(EntityTypeBuilder<Order> builder)
  {
    builder.Property(x => x.Id)
      .ValueGeneratedNever();
  }
}
public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
  void IEntityTypeConfiguration<OrderItem>.Configure(EntityTypeBuilder<OrderItem> builder)
  {
    builder.Property(x => x.Id)
      .ValueGeneratedNever();
  }
}