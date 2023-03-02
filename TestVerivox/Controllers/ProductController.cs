using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestVerivox.Request;
using TestVerivox.Repositories.Interfaces;
using static TestVerivox.Helpers.FluentValidation;

namespace TestVerivox.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("TariffCosts")]
        [HttpGet]
        public async Task<IActionResult> CompareCostsAsync([FromQuery] PowerConsumptionRequest Request)
        {
            await ValidateConsumptionRequest(Request);
            return Ok(_productRepository.CompareCostsAsync(Request));
        }
    }
}
