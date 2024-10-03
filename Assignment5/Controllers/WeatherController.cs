﻿using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Controllers
{
    public class WeatherController : Controller
    {
        List<CityWeather> cityWeathers = new List<CityWeather>()
            {
                new CityWeather()
                {
                    CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33
                },
                new CityWeather()
                {
                    CityUniqueCode = "NYC", CityName = "New York", DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60
                },
                new CityWeather()
                {
                    CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82
                }

            };
        [Route("Home")]
        public IActionResult Index()
        {
            return View(cityWeathers);
        }
        [Route("Weather-details-VC/{code?}")]
        public IActionResult WeatherDetails(string? code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var CityWeather = cityWeathers.Where(x => x.CityUniqueCode == code).FirstOrDefault();
                if (CityWeather != null)
                {
                    return View(CityWeather);
                }
            }
            return RedirectToAction("Error","Home");
        }
    }
}