namespace TestVerivox.Domain.Interfaces
{
    public interface IProducts
    {
        decimal GetAnnualCosts(ITariff product, int Consumption);
    }
}
