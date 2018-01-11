using System.ComponentModel.DataAnnotations;

namespace CurrencyConverterService.Models
{
    public class NameCurrencyModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Currency { get; set; }
    }
}
