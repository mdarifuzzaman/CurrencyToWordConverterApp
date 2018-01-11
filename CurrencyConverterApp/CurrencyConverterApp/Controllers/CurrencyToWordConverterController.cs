using System.Threading.Tasks;
using Converter.Core.Frameworks;
using CurrencyConverterService.Extensions;
using CurrencyConverterService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverterService.Controllers
{
    [Route("api/[controller]")]
    public class CurrencyToWordConverterController:Controller
    {
        
        [HttpGet, Produces("application/json")]
        public async Task<ActionResult> Convert(string name, decimal currency)
        {

            var outputModel = new NameWordViewModel
            {
                Name = name,
                Word = currency.IsInteger() ? new IntegerToWordConverter().ConvertToWord((int) currency) : new DoubleToWordConverter().ConvertToWord((double) currency)
            };

            return await Task.FromResult(this.Ok( outputModel));
        } 
    }
}
