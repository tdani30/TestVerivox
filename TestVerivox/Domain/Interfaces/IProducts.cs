namespace TestVerivox.Domain.Interfaces
{
    public interface IProducts
    {
        decimal GetAnnualCosts(IApplicantModel product, int Consumption);
    }
}
