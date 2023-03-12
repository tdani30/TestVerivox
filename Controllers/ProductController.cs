using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestVerivox.Request;
using TestVerivox.Repositories.Interfaces;
using static TestVerivox.Helpers.FluentValidation;
using TestVerivox.Model;
using System.Collections.Generic;

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
        public async Task<List<ProductDto>> CompareCostsAsync([FromQuery] PowerConsumptionRequest Request)
        {
            await ValidateConsumptionRequest(Request);

            var data = await Task.Run(() => _productRepository.CompareCostsAsync(Request));
            return data;
        }
    }
}
