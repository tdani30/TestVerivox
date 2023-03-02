using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestVerivox.Model
{
    public class ProductDto
    {
        public string TariffName { get; set; }
        public decimal AnnualCosts { get; set; }
    }
}
