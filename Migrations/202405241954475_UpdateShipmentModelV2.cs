namespace ShipmentTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateShipmentModelV2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shipments", "IsNational", c => c.Boolean(nullable: false));
            AddColumn("dbo.Shipments", "Month", c => c.String());
            AddColumn("dbo.Shipments", "IsChihuahua", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shipments", "IsChihuahua");
            DropColumn("dbo.Shipments", "Month");
            DropColumn("dbo.Shipments", "IsNational");
        }
    }
}
