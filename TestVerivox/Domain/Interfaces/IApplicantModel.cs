namespace TestVerivox.Domain.Interfaces
{
    public interface IApplicantModel
    {
        public string TariffName { get; set; }
        public int Base { get; set; }
        public decimal PricePerKwh { get; set; }
        public decimal Amount { get; set; }
        IProducts ProductProcessor { get; set; }
    }
}
