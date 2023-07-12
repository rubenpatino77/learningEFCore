using System;
using learningEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace learningEFCore.Data
{
	public class ContosoPizzaContext : DbContext
	{
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=sql_server_container;User Id=sa;Password=firstSQLPass1;TrustServerCertificate=true;");

        }
    }
}

