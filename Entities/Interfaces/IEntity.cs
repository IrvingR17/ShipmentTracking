using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracking.Entities.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }
        string TextField { get; set; }
    }
}
