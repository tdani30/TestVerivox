using System.Collections.Generic;
using System.Threading.Tasks;
using TestVerivox.Model;
using TestVerivox.Request;

namespace TestVerivox.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<ProductDto> CompareCostsAsync(PowerConsumptionRequest consumptionRequest);
    }
}
