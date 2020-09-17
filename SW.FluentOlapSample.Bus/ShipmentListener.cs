using System.Collections.Generic;
using System.Threading.Tasks;
using SW.FluentOlap.Models;
using SW.PrimitiveTypes;
using SW.FluentOlapSample.Models;

namespace SW.FluentOlapSample.Api
{
    // Listener 
    public class ShipmentListener : IConsume<ShipmentMade>
    {
        public async Task Process(ShipmentMade message)
        {
            // Init the analyzer
            var analyzer = new ShipmentWide();


            // Recieving the data
            var expandedData = await analyzer.PopulateAsync(new PopulationContext<ShipmentMade>(message));
            
            // Here the ingestion will take place.
        }
    }
}
