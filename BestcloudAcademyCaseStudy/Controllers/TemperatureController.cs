using BestcloudAcademyCaseStudy.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestcloudAcademyCaseStudy.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        [HttpGet]
        public User Get()
        {
            User user = new User();
            user.Firstname = "Nurullah";
            user.Lastname = "Akıncı";
            return user;
        }

        [HttpGet("GetTemperature/{city}")]
        public IActionResult GetTemperature([FromQuery] string city)
        {
            if (String.IsNullOrWhiteSpace(city))
                return BadRequest("Bad Request. You must enter a city.");
            WeatherForecast weather = new WeatherForecast();
            weather.Temperature = new Random().Next(-10, 20);
            return Ok(weather);
        }
    }
}
