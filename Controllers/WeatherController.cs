using System;
using Angular2App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Angular2App.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // GET api/values/5
        [HttpGet("[action]/{city}")]
        public IActionResult Get(string city)
        {
            var random = new Random();
            return Ok(new Weather
            {
                Temp = random.Next(32, 110),
                City = city,
                Summary = Summaries[random.Next(Summaries.Length)]
            });
        }
    }
}
