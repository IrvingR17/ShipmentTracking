using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipmentTracking.Entities
{
    public class Shipment
    {
        public int Id { get; set; }
        public Customer CustomerId { get; set; }
        public DeliveryPlace DeliveryPlaceId { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(35)]
        public string Invoice { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(35)]
        public string PurchaseOrder { get; set; }
        public string PurchaseOrder2 { get; set; }
        public Material MaterialDescriptionId { get; set; }
        public int Quantity { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Carrier CarrierId { get; set; }
        public string Bol { get; set; }
        public Driver DriverId { get; set; }
        public PlatformBox PlatformBoxId { get; set; }
        public DateTime ShipDate { get; set; }
        public int Quantity2 { get; set; }
        public DateTime DeliveryDate { get; set; }
        [DefaultValue(false)]
        public bool IsProcessed { get; set; }
        public bool IsNational { get; set; }
        public string Month {  get; set; }
        public bool IsChihuahua {  get; set; }

        public Shipment()
        {
            IsProcessed = false;
        }
    }
}
