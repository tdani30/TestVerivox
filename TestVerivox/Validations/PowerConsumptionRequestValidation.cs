using FluentValidation;
using TestVerivox.Request;

namespace TestVerivox.Validations
{
    public class PowerConsumptionRequestValidation : AbstractValidator<PowerConsumptionRequest>
    {
        public PowerConsumptionRequestValidation()
        {

            RuleFor(x => x.Consumption)
                .NotEmpty()
                .WithMessage("Please input the Consumption value(kWh/year)");

        }
    }
}
