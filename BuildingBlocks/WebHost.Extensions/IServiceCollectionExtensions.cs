﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
//using Newtonsoft.Json.Serialization;
//using Swashbuckle.AspNetCore.Swagger;
//using Microsoft.Extensions.Diagnostics.HealthChecks;
using RandREng.Extensions.DbContexts;

namespace RandREng.Extensions.ServiceCollection
{
    public static class CustomExtensionMethods
    {
        //public static IServiceCollection AddAppInsight(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddApplicationInsightsTelemetry(configuration);
        //    //string orchestratorType = configuration.GetValue<string>("OrchestratorType");

        //    //if (orchestratorType?.ToUpper() == "K8S")
        //    //{
        //    //	// Enable K8s telemetry initializer
        //    //	services.EnableKubernetes();
        //    //}
        //    //if (orchestratorType?.ToUpper() == "SF")
        //    //{
        //    //	// Enable SF telemetry initializer
        //    //	services.AddSingleton<ITelemetryInitializer>((serviceProvider) =>
        //    //		new FabricTelemetryInitializer());
        //    //}

        //    return services;
        //}

        public static IServiceCollection AddCustomHealthCheck(this IServiceCollection services, IConfiguration configuration)
        {
            string accountName = configuration.GetValue<string>("AzureStorageAccountName");
            string accountKey = configuration.GetValue<string>("AzureStorageAccountKey");

            string name = configuration.GetValue<string>("HealthCheck:Name");

            IHealthChecksBuilder hcBuilder = services.AddHealthChecks();

            if (!string.IsNullOrEmpty(name))
            {
                hcBuilder
                    .AddCheck(name, () => HealthCheckResult.Healthy());

            }
            bool bDb = configuration.GetValue<bool>("HealthCheck:DB:Enable");
            if (bDb)
            {
                string hcname = configuration.GetValue<string>("HealthCheck:DB:Name");
                string[] tags = configuration.GetSection("HealthCheck:DB:tags").Get<string[]>();
                hcBuilder
                    .AddSqlServer(
                        configuration["ConnectionString"],
                        name: hcname,
                        tags: tags);
            }

            bool bStorage = configuration.GetValue<bool>("HealthCheck:AzureBlobStorage:Enable");
            if (bStorage && !string.IsNullOrEmpty(accountName) && !string.IsNullOrEmpty(accountKey))
            {
                string hcname = configuration.GetValue<string>("HealthCheck:AzureBlobStorage:Name");
                string[] tags = configuration.GetSection("HealthCheck:AzureBlobStorage:tags").Get<string[]>();

                hcBuilder
                    .AddAzureBlobStorage(
                        $"DefaultEndpointsProtocol=https;AccountName={accountName};AccountKey={accountKey};EndpointSuffix=core.windows.net",
                        name: hcname,
                        tags: tags);
            }

            bool bService = configuration.GetValue<bool>("HealthCheck:AzureServiceBusTopic:Enable");
            if (bService && configuration.GetValue<bool>("AzureServiceBusEnabled"))
            {
                string hcname = configuration.GetValue<string>("HealthCheck:AzureServiceBusTopic:Name");
                string topic = configuration.GetValue<string>("HealthCheck:AzureServiceBusTopic:topicName");
                string[] tags = configuration.GetSection("HealthCheck:AzureServiceBusTopic:tags").Get<string[]>();
                hcBuilder
                    .AddAzureServiceBusTopic(
                        configuration["EventBusConnection"],
                        topicName: topic,
                        name: hcname,
                        tags: tags);
            }

            bool bRabbit = configuration.GetValue<bool>("HealthCheck:RabbitMQ:Enable");
            if (bRabbit && !configuration.GetValue<bool>("AzureServiceBusEnabled"))
            {
                string hcname = configuration.GetValue<string>("HealthCheck:RabbitMQ:Name");
                string[] tags = configuration.GetSection("HealthCheck:RabbitMQ:tags").Get<string[]>();

                hcBuilder
                    .AddRabbitMQ(
                        $"amqp://{configuration["EventBusConnection"]}",
                        name: hcname,
                        tags: tags);
            }

            return services;
        }

        //public static IServiceCollection AddCustomMVC(this IServiceCollection services, IConfiguration configuration)
        //{
        //    IHealthChecksBuilder hcBuilder = services.AddHealthChecks();

        //    hcBuilder
        //        .AddSqlServer(configuration["ConnectionString"]);



        //    services.AddHealthChecks(checks =>
        //    {
        //        //int minutes = 1;
        //        //if (int.TryParse(configuration["HealthCheck:Timeout"], out int minutesParsed))
        //        //{
        //        //	minutes = minutesParsed;
        //        //}
        //        //checks.(configuration["ConnectionString"], name: "CatalogDb", , TimeSpan.FromMinutes(minutes));

        //        //string accountName = configuration.GetValue<string>("AzureStorageAccountName");
        //        //string accountKey = configuration.GetValue<string>("AzureStorageAccountKey");
        //        //if (!string.IsNullOrEmpty(accountName) && !string.IsNullOrEmpty(accountKey))
        //        //{
        //        //	checks.AddAzureBlobStorage(accountName, accountKey);
        //        //}
        //    });

        //    services.AddMvc(options =>
        //    {
        //        options.Filters.Add(typeof(HttpGlobalExceptionFilter));
        //    })
        //    .AddControllersAsServices()
        //    .AddJsonOptions(
        //        options => {
        //            options.SerializerSettings.ContractResolver = new DefaultContractResolver();
        //            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        //        }
        //    )
        //    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        //    services.AddMvcCore()
        //        .AddAuthorization();

        //    services.AddCors(options =>
        //    {
        //        options.AddPolicy("CorsPolicy",
        //            builder => builder.AllowAnyOrigin()
        //            .AllowAnyMethod()
        //            .AllowAnyHeader()
        //            .AllowCredentials());
        //    });

        //    return services;
        //}

        public static IServiceCollection AddCustomDbContext<TContext>(this IServiceCollection services, IConfiguration configuration) where TContext : DbContext
        {
            services.AddDbContext<TContext>(options =>
            {
                options.ConfigureFromSettings<TContext>(configuration);
            });

            return services;
        }

        //public static IServiceCollection AddCustomOptions(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.Configure<Settings>(configuration);
        //    services.Configure<ApiBehaviorOptions>(options =>
        //    {
        //        options.InvalidModelStateResponseFactory = context =>
        //        {
        //            ValidationProblemDetails problemDetails = new ValidationProblemDetails(context.ModelState)
        //            {
        //                Instance = context.HttpContext.Request.Path,
        //                Status = StatusCodes.Status400BadRequest,
        //                Detail = "Please refer to the errors property for additional details."
        //            };

        //            return new BadRequestObjectResult(problemDetails)
        //            {
        //                ContentTypes = { "application/problem+json", "application/problem+xml" }
        //            };
        //        };
        //    });

        //    return services;
        //}

        //public static IServiceCollection AddSwagger(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddSwaggerGen(options =>
        //    {
        //        options.DescribeAllEnumsAsStrings();
        //        options.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
        //        {
        //            Title = "eShopOnContainers - Catalog HTTP API",
        //            Version = "v1",
        //            Description = "The Catalog Microservice HTTP API. This is a Data-Driven/CRUD microservice sample",
        //            TermsOfService = "Terms Of Service"
        //        });
        //        options.AddSecurityDefinition("oauth2", new OAuth2Scheme
        //        {
        //            Type = "oauth2",
        //            Flow = "implicit",
        //            AuthorizationUrl = $"{configuration.GetValue<string>("IdentityUrlExternal")}/connect/authorize",
        //            TokenUrl = $"{configuration.GetValue<string>("IdentityUrlExternal")}/connect/token",
        //            Scopes = new Dictionary<string, string>()
        //        {
        //            { "catalog", "Catalog API" }
        //        }
        //        });

        //        options.OperationFilter<AuthorizeCheckOperationFilter>();

        //    });

        //    return services;

        //}

        //public static IServiceCollection AddIntegrationServices(this IServiceCollection services, IConfiguration configuration)
        //{
        //    //	services.AddTransient<Func<DbConnection, IIntegrationEventLogService>>(
        //    //	   sp => (DbConnection c) => new IntegrationEventLogService(c));

        //    //	services.AddTransient<ICatalogIntegrationEventService, CatalogIntegrationEventService>();

        //    //	if (configuration.GetValue<bool>("AzureServiceBusEnabled"))
        //    //	{
        //    //		services.AddSingleton<IServiceBusPersisterConnection>(sp =>
        //    //		{
        //    //			var settings = sp.GetRequiredService<IOptions<CatalogSettings>>().Value;
        //    //			var logger = sp.GetRequiredService<ILogger<DefaultServiceBusPersisterConnection>>();

        //    //			var serviceBusConnection = new ServiceBusConnectionStringBuilder(settings.EventBusConnection);

        //    //			return new DefaultServiceBusPersisterConnection(serviceBusConnection, logger);
        //    //		});
        //    //	}
        //    //	else
        //    //	{
        //    //		services.AddSingleton<IRabbitMQPersistentConnection>(sp =>
        //    //		{
        //    //			var settings = sp.GetRequiredService<IOptions<CatalogSettings>>().Value;
        //    //			var logger = sp.GetRequiredService<ILogger<DefaultRabbitMQPersistentConnection>>();

        //    //			var factory = new ConnectionFactory()
        //    //			{
        //    //				HostName = configuration["EventBusConnection"]
        //    //			};

        //    //			if (!string.IsNullOrEmpty(configuration["EventBusUserName"]))
        //    //			{
        //    //				factory.UserName = configuration["EventBusUserName"];
        //    //			}

        //    //			if (!string.IsNullOrEmpty(configuration["EventBusPassword"]))
        //    //			{
        //    //				factory.Password = configuration["EventBusPassword"];
        //    //			}

        //    //			int retryCount = 5;
        //    //			if (!string.IsNullOrEmpty(configuration["EventBusRetryCount"]))
        //    //			{
        //    //				retryCount = int.Parse(configuration["EventBusRetryCount"]);
        //    //			}

        //    //			return new DefaultRabbitMQPersistentConnection(factory, logger, retryCount);
        //    //		});
        //    //	}

        //    return services;
        //}

        //public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        //{
        //    //	string subscriptionClientName = configuration["SubscriptionClientName"];

        //    //	if (configuration.GetValue<bool>("AzureServiceBusEnabled"))
        //    //	{
        //    //		services.AddSingleton<IEventBus, EventBusServiceBus>(sp =>
        //    //		{
        //    //			var serviceBusPersisterConnection = sp.GetRequiredService<IServiceBusPersisterConnection>();
        //    //			var iLifetimeScope = sp.GetRequiredService<ILifetimeScope>();
        //    //			var logger = sp.GetRequiredService<ILogger<EventBusServiceBus>>();
        //    //			var eventBusSubcriptionsManager = sp.GetRequiredService<IEventBusSubscriptionsManager>();

        //    //			return new EventBusServiceBus(serviceBusPersisterConnection, logger,
        //    //				eventBusSubcriptionsManager, subscriptionClientName, iLifetimeScope);
        //    //		});

        //    //	}
        //    //	else
        //    //	{
        //    //		services.AddSingleton<IEventBus, EventBusRabbitMQ>(sp =>
        //    //		{
        //    //			var rabbitMQPersistentConnection = sp.GetRequiredService<IRabbitMQPersistentConnection>();
        //    //			var iLifetimeScope = sp.GetRequiredService<ILifetimeScope>();
        //    //			var logger = sp.GetRequiredService<ILogger<EventBusRabbitMQ>>();
        //    //			var eventBusSubcriptionsManager = sp.GetRequiredService<IEventBusSubscriptionsManager>();

        //    //			int retryCount = 5;
        //    //			if (!string.IsNullOrEmpty(configuration["EventBusRetryCount"]))
        //    //			{
        //    //				retryCount = int.Parse(configuration["EventBusRetryCount"]);
        //    //			}

        //    //			return new EventBusRabbitMQ(rabbitMQPersistentConnection, logger, iLifetimeScope, eventBusSubcriptionsManager, subscriptionClientName, retryCount);
        //    //		});
        //    //	}

        //    //	services.AddSingleton<IEventBusSubscriptionsManager, InMemoryEventBusSubscriptionsManager>();
        //    //	services.AddTransient<OrderStatusChangedToAwaitingValidationIntegrationEventHandler>();
        //    //	services.AddTransient<OrderStatusChangedToPaidIntegrationEventHandler>();

        //    return services;
        //}
    }
}
