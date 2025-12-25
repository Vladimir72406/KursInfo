using Microsoft.AspNetCore.Mvc;

namespace KursInfo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyRateController : ControllerBase
    {
        /*[HttpGet]//по умолчанию
        public string Index(string _currency)
        {
            return "Test 1; Передан параметр : " + _currency;
        }

        [HttpGet("rev")]
        public string Rev(string _currency)
        {
            return _currency + " rev";
        }*/
        [HttpGet]//по умолчанию
        public decimal CurRate(string currency)
        {
            if (currency == "RUR")
                return 1;
            else if (currency == "USD")
                return 2;
            else if (currency == "EUR")
                return 3;
            else
                return 0;
        }

        
    }    
}
