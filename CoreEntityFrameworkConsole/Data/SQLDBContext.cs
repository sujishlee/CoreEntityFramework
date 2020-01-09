using CoreEntityFrameworkConsole.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEntityFrameworkConsole.Data
{
    public class SQLDBContext:DbContext
    {
        string connectionStrinng = "Data Source=D1VMDBATS01.OLDEV.PREOL.DELL.COM;Initial Catalog=AvailableToSell;Integrated Security=True;Connect Timeout=60; Pooling=true;Max Pool Size=1000;";

        public DbSet<Customer> TCustomers { get; set; }
        public DbSet<Order> TOrders { get; set; }
        public DbSet<Product> TProducts { get; set; }
        public DbSet<ProductOrder> TProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionStrinng);
           
        }

    }
}
