using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVerivox.Domain;
using TestVerivox.Domain.Interfaces;
using TestVerivox.Model;
using TestVerivox.Repositories.Interfaces;
using TestVerivox.Request;

namespace TestVerivox.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public ProductRepository()
        {
        
        }

        public List<ProductDto> CompareCostsAsync(PowerConsumptionRequest consumptionRequest)
        {
            List<ITariff> tariff = new List<ITariff>
            {
                new Basic {TariffName="Basic electricity tariff",Amount=5,Base=12,PricePerKwh=0.22m },
                new Packaged {TariffName="Packaged tariff",Amount=800,Base=1,PricePerKwh=0.30m },
            };

            List<ProductDto> product = new List<ProductDto>();

            tariff.ForEach(data =>
            {
                product.Add(new ProductDto()
                {
                    AnnualCosts = data.ProductProcessor.GetAnnualCosts(data, consumptionRequest.Consumption),
                    TariffName = data.TariffName
                });
            });
            
            //sorted by costs in ascending order.
            return product.OrderBy(x => x.AnnualCosts)?.ToList();
        }

    }
}
