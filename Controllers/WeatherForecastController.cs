using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sessions_api.Controllers
{

    /// <summary>
    /// Weather Forecast endpoint
    /// </summary>
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// Endpoint constructor
        /// </summary>
        /// <param name="logger">Logger service</param>
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        
        /// <summary>
        /// Gets the weather forecast
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /WeatherForecast
        ///
        /// </remarks>
        /// <returns>Collection of weather forecast</returns>
        /// <response code="200">Returns weather forecast</response>
        [HttpGet]
        [ProducesResponseTypeAttribute(StatusCodes.Status200OK)]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
