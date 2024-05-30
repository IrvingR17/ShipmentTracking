namespace ShipmentTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEntitiesFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carriers", "TextField", c => c.String());
            AddColumn("dbo.Customers", "TextField", c => c.String());
            AddColumn("dbo.DeliveryPlaces", "TextField", c => c.String());
            AddColumn("dbo.Drivers", "TextField", c => c.String());
            AddColumn("dbo.Materials", "TextField", c => c.String());
            AddColumn("dbo.PlatformBoxes", "TextField", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlatformBoxes", "TextField");
            DropColumn("dbo.Materials", "TextField");
            DropColumn("dbo.Drivers", "TextField");
            DropColumn("dbo.DeliveryPlaces", "TextField");
            DropColumn("dbo.Customers", "TextField");
            DropColumn("dbo.Carriers", "TextField");
        }
    }
}
