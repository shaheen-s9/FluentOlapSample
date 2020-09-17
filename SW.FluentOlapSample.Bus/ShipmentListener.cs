using System.Collections.Generic;
using System.Threading.Tasks;
using SW.PrimitiveTypes;

namespace SW.FluentOlapSample.Api
{
    public class ShipmentListener : IConsume
    {
        public Task<IEnumerable<string>> GetMessageTypeNames()
        {
            throw new System.NotImplementedException();
        }

    }
}