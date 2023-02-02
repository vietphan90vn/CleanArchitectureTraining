using CleanArchitecture.JT.Application.WeatherForecasts.Queries.GetWeatherForecasts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.JT.WebUI.Controllers;

public class WeatherForecastController : ApiControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await Mediator.Send(new GetWeatherForecastsQuery());
    }
}
