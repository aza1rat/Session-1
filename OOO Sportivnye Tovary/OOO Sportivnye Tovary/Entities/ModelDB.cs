using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OOO_Sportivnye_Tovary.Entities
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Measurement> Measurement { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PointOfDelivery> PointOfDelivery { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Receive> Receive { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.ProductCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Manufacturer)
                .HasForeignKey(e => e.ProductManufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Measurement>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Measurement)
                .HasForeignKey(e => e.ProductMeasurement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Receive)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.ReceiveID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PointOfDelivery>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.PointOfDelivery)
                .HasForeignKey(e => e.OrderPointOfDelivery)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Provider>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Provider)
                .HasForeignKey(e => e.ProductProvider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.UserRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Status)
                .HasForeignKey(e => e.OrderStatus)
                .WillCascadeOnDelete(false);
        }
    }
}
