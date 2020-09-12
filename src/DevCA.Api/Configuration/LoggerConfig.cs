using Elmah.Io.AspNetCore;
using Elmah.Io.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace DevCA.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfiguration(this IServiceCollection services)
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

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            return app;
        }
    }
}
