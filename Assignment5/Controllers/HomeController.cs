using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Controllers
{
	public class HomeController : Controller
	{
		[Route("/")]
		public IActionResult Index()
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

			return View(cityWeathers);
		}

		[Route("Weather-details/{code?}")]
		public IActionResult WheatherDetails(string? code)
		{
			if (!string.IsNullOrEmpty(code))
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
				var CityWeather = cityWeathers.Where(x => x.CityUniqueCode == code).FirstOrDefault();
				if (CityWeather != null)
				{
                    return View(CityWeather);
                }
			}
            return View("Error");
        }

		public IActionResult Error()
		{
			return View();
		}
	}
}
