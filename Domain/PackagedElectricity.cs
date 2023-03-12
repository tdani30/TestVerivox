using TestVerivox.Domain.Interfaces;

namespace TestVerivox.Domain
{
    public class PackagedElectricity : IProducts
    {
        public const int limit = 4000;
        //Calculation model: 800€ for up to 4000 kWh/year and above 4000 kWh/year additionally 30 cent/kWh
        public decimal GetAnnualCosts(ITariff product, int consumption)
        {
            return consumption <= limit ? product.Amount : product.Amount + (consumption - limit) * product.PricePerKwh;
          
        }
    }
}
