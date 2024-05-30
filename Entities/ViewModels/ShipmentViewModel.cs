using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracking.Entities.ViewModels
{
    public class ShipmentViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string DeliveryPlaceName { get; set; }
        public string Invoice { get; set; }
        public string PurchaseOrder { get; set; }
        public string PurchaseOrder2 { get; set; }
        public string MaterialDescription { get; set; }
        public int Quantity { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CarrierName { get; set; }
        public string Bol { get; set; }
        public string DriverName { get; set; }
        public string PlatformBox { get; set; }
        public DateTime ShipDate { get; set; }
        public int Quantity2 { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsProcessed { get; set; }
        public bool IsNational {  get; set; }
        public string Month {  get; set; }
        public bool IsChihuahua { get; set; }
    }
}
