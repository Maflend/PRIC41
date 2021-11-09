using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureSalesCompanyProject.Models
{
    public class FurnitureContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Category> Categories { get; set; }
        public FurnitureContext()
        {
           // Database.EnsureDeleted();
           // Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=COMP-225-10\\MSSQLSERVER1;Database=PRICMaxim;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=FirmModelPRIC;Trusted_Connection=True;");
           // optionsBuilder.UseSqlServer("Server=COMP-225-2\SQLEXPRESS;Database=;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
              .HasIndex(x => x.Code)
              .IsUnique();
        }
    }
}
