using TestVerivox.Domain.Interfaces;

namespace TestVerivox.Domain
{
    public class ProductBasicElectricity : IProducts
    {
        public decimal GetAnnualCosts(IApplicantModel product, int Consumption)
        {
            var fixedCost = product.Base * product.Amount;
            return fixedCost + Consumption * product.PricePerKwh;
        }
    }
}
