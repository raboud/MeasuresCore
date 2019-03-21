using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Reflection;
using Microsoft.Data.Sqlite;

namespace RandREng.Extensions.DbContexts
{
    public static class OptionBuilderExt
    {
        //public static DbContextOptionsBuilder ConfigureFromSettings(this DbContextOptionsBuilder optionsBuilder, IConfiguration configuration)
        //{
        //    switch (configuration["DatabaseType"])
        //    {
        //        case "InMemory":
        //            optionsBuilder.ConfigureInMemory(configuration["DatabaseConnection"]);
        //            break;

        //        case "SqlServer":
        //            optionsBuilder.ConfigureSqlServer(configuration["DatabaseConnection"]);
        //            break;

        //        case "SqlLite":
        //            optionsBuilder.ConfigureSqlLite(configuration["DatabaseConnection"]);
        //            break;
        //    }
        //    return optionsBuilder;
        //}

        public static DbContextOptionsBuilder ConfigureFromSettings<T>(this DbContextOptionsBuilder optionsBuilder, IConfiguration configuration) where T : DbContext
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

        public static DbContextOptionsBuilder ConfigureInMemory<T>(this DbContextOptionsBuilder optionsBuilder, string dbName) where T : DbContext
        {
            optionsBuilder.UseInMemoryDatabase(dbName)._ConfigureCommon();
            return optionsBuilder;
        }

        //public static DbContextOptionsBuilder ConfigureInMemory(this DbContextOptionsBuilder optionsBuilder, string dbName)
        //{
        //    optionsBuilder.UseInMemoryDatabase(dbName)._ConfigureCommon();
        //    return optionsBuilder;
        //}

        public static DbContextOptionsBuilder ConfigureSqlServer<T>(this DbContextOptionsBuilder optionsBuilder, string connection) where T : DbContext
        {
            optionsBuilder.UseSqlServer(
                connection,
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(T).GetTypeInfo().Assembly.GetName().Name);
                    //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                }
            )._ConfigureCommon();
            return optionsBuilder;
        }

        //public static DbContextOptionsBuilder ConfigureSqlServer(this DbContextOptionsBuilder optionsBuilder, string connection)
        //{
        //    optionsBuilder.UseSqlServer(
        //        connection,
        //        sqlServerOptionsAction: sqlOptions =>
        //        {
        //            sqlOptions.MigrationsAssembly(typeof(MeasureContext).GetTypeInfo().Assembly.GetName().Name);
        //            //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
        //            sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
        //        }
        //    )._ConfigureCommon();
        //    return optionsBuilder;
        //}
        public static DbContextOptionsBuilder ConfigureSqlLite<T>(this DbContextOptionsBuilder optionsBuilder, string connection) where T : DbContext
        {
            optionsBuilder.UseSqlite(
                connection,
                sqliteOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(T).GetTypeInfo().Assembly.GetName().Name);
                    //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
                    //                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                }
            )._ConfigureCommon();
            return optionsBuilder;
        }
//        public static DbContextOptionsBuilder ConfigureSqlLite(this DbContextOptionsBuilder optionsBuilder, string connection)
//        {
//            optionsBuilder.UseSqlite(
//                connection,
//                sqliteOptionsAction: sqlOptions =>
//                {
//                    sqlOptions.MigrationsAssembly(typeof(MeasureContext).GetTypeInfo().Assembly.GetName().Name);
//                    //Configuring Connection Resiliency: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-resiliency 
////                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
//                }
//            )._ConfigureCommon();
//            return optionsBuilder;
//        }


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

}
