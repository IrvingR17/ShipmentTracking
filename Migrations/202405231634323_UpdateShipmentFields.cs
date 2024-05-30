namespace ShipmentTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateShipmentFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shipments", "Invoice", c => c.String(maxLength: 35));
            AlterColumn("dbo.Shipments", "PurchaseOrder", c => c.String(maxLength: 35));
            CreateIndex("dbo.Shipments", "Invoice", unique: true);
            CreateIndex("dbo.Shipments", "PurchaseOrder", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Shipments", new[] { "PurchaseOrder" });
            DropIndex("dbo.Shipments", new[] { "Invoice" });
            AlterColumn("dbo.Shipments", "PurchaseOrder", c => c.String());
            AlterColumn("dbo.Shipments", "Invoice", c => c.String());
        }
    }
}
