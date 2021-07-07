using FizzBuzz.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FizzBuzz.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController: ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;
        private readonly ILogger<FizzBuzzController> _logger;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService, ILogger<FizzBuzzController> logger)
        {
            _fizzBuzzService = fizzBuzzService;
            _logger = logger;
        }

        [HttpGet("{value:int}")]
        public IActionResult Get(int value)
        {
            _logger.LogInformation($"Requested for {value}");
            return Ok(_fizzBuzzService.Calculate(value));
        }
    }
}
