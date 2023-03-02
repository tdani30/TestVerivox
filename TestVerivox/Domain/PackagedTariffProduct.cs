using TestVerivox.Domain.Interfaces;

namespace TestVerivox.Domain
{
    public class PackagedTariffProduct : IApplicantModel
    {
        public string TariffName { get; set; }
        public int Base { get; set; }
        public decimal PricePerKwh { get; set; }
        public decimal Amount { get; set; }
        public IProducts ProductProcessor { get; set; } = new ProductPackagedElectricity();
    }
}
