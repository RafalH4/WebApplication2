using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IService _service;


        public WeatherForecastController(IService service)
        {
            _service = service;
        }

        [HttpGet("first")]
        public async Task<IActionResult> Get1()
        {
            try
            {
                await _service.AddFirstDoc();
            }
            catch(Exception ex)
            {

            }
            return Ok("");
        }

        [HttpGet("second")]
        public async Task<IActionResult> Get2()
        {
            await _service.AddSecondDoc();
            return Ok("");
        }
    }
}
