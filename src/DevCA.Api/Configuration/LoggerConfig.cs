using DevCA.Api.Extensions;
using Elmah.Io.AspNetCore;
using Elmah.Io.AspNetCore.HealthChecks;
using Elmah.Io.Extensions.Logging;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace DevCA.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "9263d7825aba4e4683ab6c1b11540f88";
                o.LogId = new Guid("41ad137c-0af2-4eb7-b69e-deae6053d313");
            });

            services.AddLogging(builder => 
            {
                builder.AddElmahIo(o =>
                {
                    o.ApiKey = "9263d7825aba4e4683ab6c1b11540f88";
                    o.LogId = new Guid("41ad137c-0af2-4eb7-b69e-deae6053d313");
                });

                builder.AddFilter<ElmahIoLoggerProvider>(null, LogLevel.Warning);
            });

            services.AddHealthChecks()
                .AddElmahIoPublisher(elmah => 
                {
                    elmah.ApiKey = "9263d7825aba4e4683ab6c1b11540f88";
                    elmah.LogId = new Guid("41ad137c-0af2-4eb7-b69e-deae6053d313");
                    elmah.HeartbeatId = "FORNECEDORES_ID";
                    elmah.Application = "Api Fornecedores";
                })
                .AddCheck("Produtos", new SqlServerHealthCheck(configuration.GetConnectionString("DefaultConnection")))
                .AddSqlServer(configuration.GetConnectionString("DefaultConnection"), name: "BancoSQL");

            services.AddHealthChecksUI()
                .AddInMemoryStorage();

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            app.UseHealthChecks("/hc", new HealthCheckOptions()
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            app.UseHealthChecksUI(options =>
            {
                options.UIPath = "/hc-ui";
            });

            return app;
        }
    }
}
