using E_Commerce_Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Database
{
    public class ProjectContext : DbContext
    {

        // Register class Models 

       public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order_Product> Order_Product { get; set; }
      




        // Connection string (the connection)

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=Aziz\\SQLEXPRESS;Database=ECommercDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }



        }
    }
