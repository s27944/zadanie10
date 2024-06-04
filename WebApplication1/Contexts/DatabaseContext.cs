﻿using Microsoft.EntityFrameworkCore;
using Zadanie10;

namespace WebApplication1.Contexts;

public class DatabaseContext : DbContext
{
    public DbSet<Accounts> Accounts { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Products_Categories> Product_Categories { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<Shopping_Carts> Shopping_Carts { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}