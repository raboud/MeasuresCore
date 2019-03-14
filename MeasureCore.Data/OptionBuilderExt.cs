using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Polly;
using Polly.Retry;
using RandREng.MeasuresCore.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RandREng.MeasuresCore.Data
{
    public static class OptionBuilderExt
    {
        public static DbContextOptionsBuilder ConfigureFromSettings(this DbContextOptionsBuilder optionsBuilder, IConfiguration configuration)
        {
            switch (configuration["DatabaseType"])
            {
                case "InMemory":
                    optionsBuilder.ConfigureInMemory(configuration["DatabaseConnection"]);
                    break;

                case "SqlServer":
                    optionsBuilder.ConfigureSqlServer(configuration["DatabaseConnection"]);
                    break;

                case "SqlLite":
                    optionsBuilder.ConfigureSqlLite(configuration["DatabaseConnection"]);
                    break;
            }
            return optionsBuilder;
        }

        public static DbContextOptionsBuilder<T> ConfigureFromSettings<T>(this DbContextOptionsBuilder<T> optionsBuilder, IConfiguration configuration) where T : DbContext
        {
            switch (configuration["DatabaseType"])
            {
                case "InMemory":
                    optionsBuilder.ConfigureInMemory<T>(configuration["DatabaseConnection"]);
                    break;

                case "SqlServer":
                    optionsBuilder.ConfigureSqlServer<T>(configuration["DatabaseConnection"]);
                    break;

                case "SqlLite":
                    optionsBuilder.ConfigureSqlLite<T>(configuration["DatabaseConnection"]);
                    break;
            }
            return optionsBuilder;
        }

        public static DbContextOptionsBuilder<T> ConfigureInMemory<T>(this DbContextOptionsBuilder<T> optionsBuilder, string dbName) where T : DbContext
        {
            optionsBuilder.UseInMemoryDatabase<T>(dbName)._ConfigureCommon();
            return optionsBuilder;
        }

        public static DbContextOptionsBuilder ConfigureInMemory(this DbContextOptionsBuilder optionsBuilder, string dbName)
        {
            optionsBuilder.UseInMemoryDatabase(dbName)._ConfigureCommon();
            return optionsBuilder;
        }

        public static DbContextOptionsBuilder<T> ConfigureSqlServer<T>(this DbContextOptionsBuilder<T> optionsBuilder, string connection) where T : DbContext
        {
            optionsBuilder.UseSqlServer<T>(
                connection,
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(MeasureEntities).GetTypeInfo().Assembly.GetName().Name);
                    //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                }
            )._ConfigureCommon();
            return optionsBuilder;
        }

        public static DbContextOptionsBuilder ConfigureSqlServer(this DbContextOptionsBuilder optionsBuilder, string connection)
        {
            optionsBuilder.UseSqlServer(
                connection,
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(MeasureEntities).GetTypeInfo().Assembly.GetName().Name);
                    //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                }
            )._ConfigureCommon();
            return optionsBuilder;
        }
        public static DbContextOptionsBuilder<T> ConfigureSqlLite<T>(this DbContextOptionsBuilder<T> optionsBuilder, string connection) where T : DbContext
        {
            optionsBuilder.UseSqlite<T>(
                connection,
                sqliteOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(MeasureEntities).GetTypeInfo().Assembly.GetName().Name);
                    //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
                    //                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                }
            )._ConfigureCommon();
            return optionsBuilder;
        }
        public static DbContextOptionsBuilder ConfigureSqlLite(this DbContextOptionsBuilder optionsBuilder, string connection)
        {
            optionsBuilder.UseSqlite(
                connection,
                sqliteOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(MeasureEntities).GetTypeInfo().Assembly.GetName().Name);
                    //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
//                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                }
            )._ConfigureCommon();
            return optionsBuilder;
        }


        private static void _ConfigureSqlServer(DbContextOptionsBuilder optionsBuilder, string connection)
        {
            optionsBuilder._ConfigureCommon();
        }

        private static void _ConfigureCommon(this DbContextOptionsBuilder optionsBuilder)
        {
            // Changing default behavior when client evaluation occurs to throw. 
            // Default in EF Core would be to log a warning when client evaluation is performed.
            optionsBuilder.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
            //Check Client vs. Server evaluation: https://docs.microsoft.com/en-us/ef/core/querying/client-eval

        }

    }

    public class ContextSeed
    {
        public MeasureEntities Context;
        public ILogger<ContextSeed> Logger;
        public string ContentRootPath { get; set; }

        public Task SeedAsync(MeasureEntities context, IHostingEnvironment env, ILogger<ContextSeed> logger)
        {
            this.Context = context;
            this.Logger = logger;
            ContentRootPath = env.ContentRootPath;
            return SeedAsync();
        }

        public Task SeedAsync(MeasureEntities context, ILogger<ContextSeed> logger, string contentRootPath)
        {
            this.Context = context;
            this.Logger = logger;
            this.ContentRootPath = contentRootPath;
            return SeedAsync();
        }

        private async Task SeedAsync()
        {
            Logger.LogInformation("Enterring SeedAsync");

            AsyncRetryPolicy policy = CreatePolicy(nameof(ContextSeed));

            await policy.ExecuteAsync(async () =>
            {
                string fileName = Path.Combine(ContentRootPath, "Setup", "Catalog.json");
                if (File.Exists(fileName))
                {
                    QueryTrackingBehavior initialState = Context.ChangeTracker.QueryTrackingBehavior;
                    Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

                    string raw;
                    using (StreamReader sourceReader = File.OpenText(fileName))
                    {
                        raw = await sourceReader.ReadToEndAsync();
                    }
                    dynamic data = JObject.Parse(raw);

                    await ProcessPhoneNumberType(data.PhoneNumberType);
                    //await ProcessVendors(data.Vendors);
                    //await ProcessUnits(data.Units);
                    //await ProcessCategories(data.Categories);
                    //await ProcessProducts(data.Products);

                    await Context.SaveChangesAsync();

                    Context.ChangeTracker.QueryTrackingBehavior = initialState;
                }

                //				GetCatalogItemPictures(contentRootPath, picturePath);
            });
        }

        private AsyncRetryPolicy CreatePolicy(string prefix, int retries = 3)
        {
            return Policy.Handle<SqlException>().
                WaitAndRetryAsync(
                    retryCount: retries,
                    sleepDurationProvider: retry => System.TimeSpan.FromSeconds(5),
                    onRetry: (exception, timeSpan, retry, ctx) =>
                    {
                        Logger.LogTrace($"[{prefix}] Exception {exception.GetType().Name} with message ${exception.Message} detected on attempt {retry} of {retries}");
                    }
                );
        }

        async Task ProcessPhoneNumberType(dynamic items)
        {
            List<PhoneNumberType> data = await Context.PhoneNumberTypes.ToListAsync();
            foreach (string item in items)
            {
                if (!data.Any(b => b.Name == item))
                {
                    Context.PhoneNumberTypes.Add(new PhoneNumberType() { Name = item });
                }
            }
            await Context.SaveChangesAsync();
        }

        //async Task ProcessVendors(dynamic items)
        //{
        //    List<Vendor> data = await Context.Vendors.ToListAsync();
        //    foreach (string item in items)
        //    {
        //        if (!data.Any(b => b.Name == item))
        //        {
        //            Context.Vendors.Add(new Vendor() { Name = item });
        //        }
        //    }
        //    await Context.SaveChangesAsync();
        //}

        //async Task ProcessUnits(dynamic items)
        //{
        //    List<Unit> data = await Context.Units.ToListAsync();
        //    foreach (string item in items)
        //    {
        //        if (!data.Any(b => b.Name == item))
        //        {
        //            Context.Units.Add(new Unit() { Name = item });
        //        }
        //    }
        //    await Context.SaveChangesAsync();
        //}

        //async Task ProcessCategories(dynamic items)
        //{
        //    List<Category> data = await Context.Categories.ToListAsync();
        //    foreach (dynamic item in items)
        //    {
        //        if (!data.Any(b => b.Name == (string)item.Name))
        //        {
        //            Category category = new Category() { Name = item.Name };
        //            foreach (dynamic child in item.Children)
        //            {
        //                if (!data.Any(b => b.Name == (string)child.Name))
        //                {
        //                    category.Children.Add(new Category() { Name = child.Name });
        //                }
        //            }
        //            Context.Categories.Add(category);
        //        }
        //    }
        //    int changes = await Context.SaveChangesAsync();
        //}


        //async Task ProcessProducts(dynamic items)
        //{
        //    Logger.LogInformation("Enterring ProcessProducts");

        //    List<Brand> brands = await Context.Brands.ToListAsync();
        //    List<Vendor> vendors = await Context.Vendors.ToListAsync();
        //    List<Category> categories = await Context.Categories.ToListAsync();
        //    List<Unit> units = await Context.Units.ToListAsync();

        //    List<ItemCategory> pcs = new List<ItemCategory>();

        //    List<Item> data = await Context.Items.ToListAsync();
        //    foreach (dynamic item in items)
        //    {
        //        if (!data.Any(b => b.Name == (string)item.Name)) // && b.Count == (int)item.Count))
        //        {
        //            Brand brand = brands.FirstOrDefault(b => b.Name == (string)item.Brand);

        //            if (brand == null)
        //            {
        //                string name = item.Name;
        //                Logger.LogError("invalid item", name);
        //                return;
        //            }
        //            Item p = new Item
        //            {
        //                //						Id = item.Id,
        //                Name = item.Name,
        //                Brand = brand
        //            };
        //            p.BrandId = p.Brand.Id;
        //            p.Description = item.Description;
        //            p.PictureFileName = item.PictureFileName;

        //            foreach (dynamic variant in item.Variants)
        //            {
        //                Variant v = new Variant
        //                {
        //                    Item = p
        //                };
        //                Unit unit = units.FirstOrDefault(b => b.Name == (string)variant.Unit);
        //                Vendor vendor = vendors.FirstOrDefault(b => b.Name == (string)variant.Vendor);
        //                v.Count = variant.Count;
        //                //p.Unit = unit;
        //                v.UnitId = unit.Id;

        //                //p.Vendor = vendor;
        //                v.VendorId = vendor.Id;
        //                v.AvailableStock = variant.AvailableStock;
        //                v.Cost = variant.Cost;
        //                v.MaxStockThreshold = variant.MaxStockThreshold;
        //                v.Price = variant.Price;
        //                v.RestockThreshold = variant.RestockThreshold;
        //                v.SuggestPrice = variant.SuggestPrice;
        //                p.Variants.Add(v);
        //            }


        //            await Context.Items.AddAsync(p);
        //            //					await context.SaveChangesAsync();

        //            foreach (string category in item.Categories)
        //            {
        //                ItemCategory pc = new ItemCategory
        //                {
        //                    ItemId = p.Id,
        //                    Category = categories.FirstOrDefault(c => c.Name == category)
        //                };
        //                p.ItemCategories.Add(pc);
        //            }
        //        }
        //    }
        //    //			await context.ProductCategories.AddRangeAsync(pcs);
        //    await Context.SaveChangesAsync();
        //}

    }

}
