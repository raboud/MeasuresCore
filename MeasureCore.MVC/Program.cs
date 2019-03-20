using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using RandREng.Extensions.WebHost;
using RandREng.MeasuresCore.Data;

namespace MeasureCore.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = GetConfiguration();
            CreateHostBuilder(configuration, args)
                .Build()
                .MigrateDbContext<MeasureContext>((context, services) =>
                {
                    var env = services.GetService<IWebHostEnvironment>().ContentRootPath;
                    var logger = services.GetService<ILogger<ContextSeed>>();

                    new ContextSeed()
                        .SeedAsync(context, logger, env)
                        .Wait();
                })
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(IConfiguration configuration, string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.CaptureStartupErrors(false);
                    webBuilder.UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                    webBuilder.UseConfiguration(configuration);
                });

        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            var config = builder.Build();

            return builder.Build();
        }
    }
}
