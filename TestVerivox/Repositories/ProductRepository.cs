using System.Collections.Generic;
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
        public List<ProductDto> CompareCostsAsync(PowerConsumptionRequest consumptionRequest)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new BasicTariffProduct {TariffName="Basic electricity tariff",Amount=5,Base=12,PricePerKwh=0.22m },
                new PackagedTariffProduct {TariffName="Packaged tariff",Amount=800,Base=1,PricePerKwh=0.30m },
            };
            List<ProductDto> dto = new List<ProductDto>();

            foreach (var person in applicants)
            {
                dto.Add(new ProductDto()
                {
                    AnnualCosts = person.ProductProcessor.GetAnnualCosts(person, consumptionRequest.Consumption),
                    TariffName = person.TariffName
                });
            }
            return dto;
        }

    }
}
