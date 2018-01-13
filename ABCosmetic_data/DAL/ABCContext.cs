using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ABCosmetic_data.DAL
{
    public class ABCContext : DbContext
    {
        public ABCContext() : base("ABCContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Payment>()
            .HasRequired(c => c.User)
            .WithMany()
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
             .HasRequired(c => c.Staff)
             .WithMany()
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
            .HasRequired(c => c.Customer)
            .WithMany()
            .WillCascadeOnDelete(false);
        }
    }
}