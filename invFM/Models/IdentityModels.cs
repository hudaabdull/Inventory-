using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace invFM.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<CEO> CEO { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Designer> Designer { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Purchase_Order> Purchase_Order { get; set; }
        public virtual DbSet<Quotation> Quotation { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<AdminItem> AdminItem { get; set; }
        public virtual DbSet<CustomerItem> CustomerItem { get; set; }
        public virtual DbSet<PurchaseOrder_Item> PurchaseOrder_Item { get; set; }
        public virtual DbSet<ShipmentDetails> ShipmentDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Admin>()
                .HasMany(e => e.AdminItem)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Admin>()
                .HasMany(e => e.Purchase_Order)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Admin>()
                .HasMany(e => e.Quotation)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEO>()
                .HasMany(e => e.Purchase_Order)
                .WithRequired(e => e.CEO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerItem)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Shipment)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Designer>()
                .HasMany(e => e.Item)
                .WithRequired(e => e.Designer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.UnitPrice)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.AdminItem)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.CustomerItem)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.PurchaseOrder_Item)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ShipmentDetails)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Purchase_Order>()
                .HasMany(e => e.PurchaseOrder_Item)
                .WithRequired(e => e.Purchase_Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Purchase_Order>()
                .HasMany(e => e.Quotation)
                .WithRequired(e => e.Purchase_Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quotation>()
                .Property(e => e.TotalPrice)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Quotation>()
                .Property(e => e.TaxCost)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Shipment>()
                .HasMany(e => e.ShipmentDetails)
                .WithRequired(e => e.Shipment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Purchase_Order)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Quotation)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Shipment)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrder_Item>()
                .Property(e => e.POItemUnitPrice)
                .HasPrecision(8, 2);
        }

        public System.Data.Entity.DbSet<invFM.ViewModels.AdminViewModel> AdminViewModels { get; set; }
    }

    
}
    