using ShipmentTracking.Entities;
using System.Data.Entity;

namespace ShipmentTracking.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeliveryPlace> DeliveryPlaces { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<PlatformBox> PlatformBoxes { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext() : base("Data Source=CUU000020\\SQLEXPRESS;Initial Catalog=ShipmentTrackingDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;")
        {
        }
    }
}
