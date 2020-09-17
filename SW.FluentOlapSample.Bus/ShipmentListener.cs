using System.Collections.Generic;
using System.Threading.Tasks;
using SW.PrimitiveTypes;
using SW.FluentOlapSample.Models;

namespace SW.FluentOlapSample.Api
{
    public class ShipmentListener : IConsume<ShipmentMade>
    {
        public Task Process(ShipmentMade message)
        {
            
        }
    }
}