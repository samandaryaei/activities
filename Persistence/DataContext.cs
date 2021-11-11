﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Value>().HasData(
            new Value { Id = 1, Name = "Value 101" },
            new Value { Id = 2, Name = "Value 102" },
            new Value { Id = 3, Name = "Value 103" }
        );
    }

    public DbSet<Value> Values { get; set; }
}
