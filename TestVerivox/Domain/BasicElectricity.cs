using TestVerivox.Domain.Interfaces;

namespace TestVerivox.Domain
{
    public class BasicElectricity : IProducts
    {
        //Calculation model: base costs per month 5€ + consumption costs 22 cent/kWh
        public decimal GetAnnualCosts(ITariff product, int consumption)
        {
            var fixedCost = product.Base * product.Amount;
            return fixedCost + consumption * product.PricePerKwh;
        }
    }
}
