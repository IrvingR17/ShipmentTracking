using ShipmentTracking.Entities.Interfaces;

namespace ShipmentTracking.Entities
{
    public class Material : IEntity
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
