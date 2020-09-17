using System.Reflection;
using System.Runtime.CompilerServices;
using SW.FluentOlap.AnalyticalNode;

namespace SW.FluentOlapSample.Models
{
    // Domain Model
    public class Shipment
    {
        public int Id { get; set; }
        //Contains reference to a courier
        public int CourierId { get; set; }
        public string Contents { get; set; }
    }

    // Wide table definition using AnalyticalObject
    public class ShipmentWide : AnalyticalObject<Shipment>
    {
        public ShipmentWide()
        {
            // Associating this wide table with a message in the system to initiate expansion and population
            Handles("ShipmentMade", "ShipmentId");
            Property(s => s.CourierId).GetFromService("couriers", new AnalyticalObject<Courier>());
        }
    }
}