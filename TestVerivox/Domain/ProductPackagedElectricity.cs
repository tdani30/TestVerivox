using TestVerivox.Domain.Interfaces;

namespace TestVerivox.Domain
{
    public class ProductPackagedElectricity : IProducts
    {
        public const int Limit = 4000;
        public decimal GetAnnualCosts(IApplicantModel product, int Consumption)
        {
            var fixedCost = product.Base * product.Amount;
            Consumption = Consumption - Limit;
            return Consumption < 0 ?
                fixedCost :
                fixedCost + Consumption * product.PricePerKwh;
        }
    }
}
