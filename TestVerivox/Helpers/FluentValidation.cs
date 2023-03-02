using System.Threading.Tasks;
using System;
using TestVerivox.Request;
using TestVerivox.Validations;

namespace TestVerivox.Helpers
{
    public class FluentValidation
    {
        public static async Task ValidateConsumptionRequest(PowerConsumptionRequest request)
        {
            var validator = await new PowerConsumptionRequestValidation().ValidateAsync(request);
            if (!validator.IsValid)
                throw new ArgumentException(validator.ToString());
        }
    }
}
