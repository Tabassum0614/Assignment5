using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment5.ViewComponents
{
    [ViewComponent]
    public class WeatherBoxViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather modeldata)
        {
            return View(modeldata);
        }
    }
}
