using ShipmentTracking.Entities.Interfaces;

namespace ShipmentTracking.Entities
{
    public class PlatformBox : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string TextField
        {
            get { return Description; }
            set { Description = value; }
        }
    }
}
