using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using stalquer_server.Models;

namespace stalquer_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BadPlaceController : ControllerBase
    {

        // public BadPlaceController(MemoryCache memoryCache)
        // {
        //     _memoryCache = memoryCache;
        // }

        [HttpGet]
        public List<BadPlaceResponse> Get()
        {
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();
            return new List<BadPlaceResponse>();
        }
    }
}
