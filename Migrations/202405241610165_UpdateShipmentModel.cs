namespace ShipmentTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateShipmentModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shipments", "IsProcessed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shipments", "IsProcessed");
        }
    }
}
