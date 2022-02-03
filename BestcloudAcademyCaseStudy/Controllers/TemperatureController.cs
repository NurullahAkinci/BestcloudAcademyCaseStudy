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
        //[HttpGet]
        //public User Get()
        //{
        //    User user = new User();
        //    user.Firstname = "Nurullah";
        //    user.Lastname = "Akıncı";
        //    return user;
        //}

        [HttpGet]
        public IActionResult Get([FromQuery(Name = "city")] string city)
        {
            if (String.IsNullOrWhiteSpace(city))
            {
                User user = new User();
                user.Firstname = "Nurullah";
                user.Lastname = "Akıncı";
                return Ok(user);
            }
            WeatherForecast weather = new WeatherForecast();
            weather.Temperature = new Random().Next(-10, 20);
            return Ok(weather);
        }
    }
}
