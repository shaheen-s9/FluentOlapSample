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

            ServiceDefinitions services = new ServiceDefinitions
            {
                ["couriers"] = new Service
                {
                    Endpoint = "/cqapi/couriers",
                    BaseUrl = "aRandomSite.com"
                },
                ["shipments"] = new Service
                {
                    Endpoint = "/cqapi/shipments",
                    BaseUrl = "aRandomSite.com"
                }
            };

            // Updating the services can be done anywhere, including startup.
            FluentOlapConfiguration.ServiceDefinitions = services;

            // Recieving the data
            var expandedData = await analyzer.PopulateAsync(new PopulationContext<ShipmentMade>(message));
            
            // Here the ingestion will take place.
        }
    }
}
