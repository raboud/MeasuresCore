using RandREng.MeasuresCore.Data;
using RandREng.MeasuresCore.Domain;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Microsoft.Extensions.Options;

namespace ConsoleApp
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            // create service collection
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // create service provider
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            // entry to run app
            serviceProvider.GetService<App>().Run();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddConsole();
                loggingBuilder.AddDebug();
            });

            // add logging
            serviceCollection.AddLogging();

            // build configuration
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", false)
              .Build();
            serviceCollection.AddOptions();
            serviceCollection.Configure<AppSettings>(configuration.GetSection("Configuration"));

            // add app
            serviceCollection.AddTransient<App>();
        }
    }

    public class AppSettings
    {
        public string Title { get; set; }
    }

    class App
    {
        private readonly ILogger<App> _logger;
        private readonly AppSettings _config;

        public App(IOptions<AppSettings> config,
                    ILogger<App> logger)
        {
            _logger = logger;
            _config = config.Value;
        }

        public void Run()
        {
            _logger.LogInformation($"This is a console application for {_config.Title}");

            var serviceCollection = new ServiceCollection();
            using (MeasureContext context = new MeasureContext(null))
            {
                PhoneNumberType fax = new PhoneNumberType { Name = "Fax" };
                PhoneNumberType work = new PhoneNumberType { Name = "Work" };

                Client parent = new Client { CompanyName = "Home Depot", Address = new Address(), BillingAddress = new Address() };
                Client store = new Client { CompanyName = "Store 127", Address = new Address(), BillingAddress = new Address(), Parent = parent };
                context.Clients.Add(store);
                store.PhoneNumbers.Add(new PhoneNumberClient { Number = "555.666.7777", PhoneNumberType = fax });
                store.PhoneNumbers.Add(new PhoneNumberClient { Number = "555.666.7778", PhoneNumberType = fax });
                store.PhoneNumbers.Add(new PhoneNumberClient { Number = "555.666.8777", PhoneNumberType = work });
                store.PhoneNumbers.Add(new PhoneNumberClient { Number = "555.666.8778", PhoneNumberType = work });
                parent.PhoneNumbers.Add(new PhoneNumberClient { Number = "555.667.7777", PhoneNumberType = fax });
                parent.PhoneNumbers.Add(new PhoneNumberClient { Number = "555.667.7778", PhoneNumberType = fax });
                parent.PhoneNumbers.Add(new PhoneNumberClient { Number = "555.667.8777", PhoneNumberType = work });
                parent.PhoneNumbers.Add(new PhoneNumberClient { Number = "555.667.8778", PhoneNumberType = work });
                context.Clients.Add(parent);
                int count = context.SaveChanges();
                List<Client> customers = context.Clients.ToList();





            }
        }
    }
}
