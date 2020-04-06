using System;

namespace sessions_api
{
    /// <summary>
    /// Weather Forecast
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Date
        /// </summary>
        /// <value>date</value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Temperature in Celsius Degree
        /// </summary>
        /// <value>C</value>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temperature in Fahrenheit Degree
        /// </summary>
        /// <returns>F</returns>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Weather Conditions
        /// </summary>
        /// <value>description</value>
        public string Summary { get; set; }
    }
}
