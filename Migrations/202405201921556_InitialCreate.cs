namespace ShipmentTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carriers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DeliveryPlaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlatformBoxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Invoice = c.String(),
                        PurchaseOrder = c.String(),
                        PurchaseOrder2 = c.String(),
                        Quantity = c.Int(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false),
                        Bol = c.String(),
                        ShipDate = c.DateTime(nullable: false),
                        Quantity2 = c.Int(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        CarrierId_Id = c.Int(),
                        CustomerId_Id = c.Int(),
                        DeliveryPlaceId_Id = c.Int(),
                        DriverId_Id = c.Int(),
                        MaterialDescriptionId_Id = c.Int(),
                        PlatformBoxId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carriers", t => t.CarrierId_Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId_Id)
                .ForeignKey("dbo.DeliveryPlaces", t => t.DeliveryPlaceId_Id)
                .ForeignKey("dbo.Drivers", t => t.DriverId_Id)
                .ForeignKey("dbo.Materials", t => t.MaterialDescriptionId_Id)
                .ForeignKey("dbo.PlatformBoxes", t => t.PlatformBoxId_Id)
                .Index(t => t.CarrierId_Id)
                .Index(t => t.CustomerId_Id)
                .Index(t => t.DeliveryPlaceId_Id)
                .Index(t => t.DriverId_Id)
                .Index(t => t.MaterialDescriptionId_Id)
                .Index(t => t.PlatformBoxId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shipments", "PlatformBoxId_Id", "dbo.PlatformBoxes");
            DropForeignKey("dbo.Shipments", "MaterialDescriptionId_Id", "dbo.Materials");
            DropForeignKey("dbo.Shipments", "DriverId_Id", "dbo.Drivers");
            DropForeignKey("dbo.Shipments", "DeliveryPlaceId_Id", "dbo.DeliveryPlaces");
            DropForeignKey("dbo.Shipments", "CustomerId_Id", "dbo.Customers");
            DropForeignKey("dbo.Shipments", "CarrierId_Id", "dbo.Carriers");
            DropIndex("dbo.Shipments", new[] { "PlatformBoxId_Id" });
            DropIndex("dbo.Shipments", new[] { "MaterialDescriptionId_Id" });
            DropIndex("dbo.Shipments", new[] { "DriverId_Id" });
            DropIndex("dbo.Shipments", new[] { "DeliveryPlaceId_Id" });
            DropIndex("dbo.Shipments", new[] { "CustomerId_Id" });
            DropIndex("dbo.Shipments", new[] { "CarrierId_Id" });
            DropTable("dbo.Shipments");
            DropTable("dbo.PlatformBoxes");
            DropTable("dbo.Materials");
            DropTable("dbo.Drivers");
            DropTable("dbo.DeliveryPlaces");
            DropTable("dbo.Customers");
            DropTable("dbo.Carriers");
        }
    }
}
