using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace sessions_api
{
    /// <summary>
    /// API main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// API start method
        /// </summary>
        /// <param name="args">Default args</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Start the host
        /// </summary>
        /// <param name="args">Default args</param>
        /// <returns>IHostBuilder</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
