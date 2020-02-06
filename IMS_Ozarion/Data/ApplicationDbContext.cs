using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ozarion.Models;

namespace ozarion.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<ozarion.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<ozarion.Models.Bill> Bill { get; set; }

        public DbSet<ozarion.Models.BillType> BillType { get; set; }

        public DbSet<ozarion.Models.Branch> Branch { get; set; }

        public DbSet<ozarion.Models.CashBank> CashBank { get; set; }

        public DbSet<ozarion.Models.Currency> Currency { get; set; }

        public DbSet<ozarion.Models.Customer> Customer { get; set; }

        public DbSet<ozarion.Models.CustomerType> CustomerType { get; set; }

        public DbSet<ozarion.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<ozarion.Models.Invoice> Invoice { get; set; }

        public DbSet<ozarion.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<ozarion.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<ozarion.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<ozarion.Models.PaymentType> PaymentType { get; set; }

        public DbSet<ozarion.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<ozarion.Models.Product> Product { get; set; }

        public DbSet<ozarion.Models.ProductType> ProductType { get; set; }

        public DbSet<ozarion.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<ozarion.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<ozarion.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<ozarion.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<ozarion.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<ozarion.Models.SalesType> SalesType { get; set; }

        public DbSet<ozarion.Models.Shipment> Shipment { get; set; }

        public DbSet<ozarion.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<ozarion.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<ozarion.Models.Vendor> Vendor { get; set; }

        public DbSet<ozarion.Models.VendorType> VendorType { get; set; }

        public DbSet<ozarion.Models.Warehouse> Warehouse { get; set; }

        public DbSet<ozarion.Models.UserProfile> UserProfile { get; set; }
    }
}
