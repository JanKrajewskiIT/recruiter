using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Extensions.Api.Configuration;

internal static class CorsExtensions
{
    private const string allCors = "allCors";

    internal static IServiceCollection AddAllCors( this IServiceCollection services )
    {
        services.AddCors( options =>
        {
            options.AddPolicy( allCors, policy =>
            {
                policy.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            } );
        } );

        return services;
    }

    internal static IApplicationBuilder UseAllCors( this IApplicationBuilder app )
    {
        app.UseCors( allCors );

        return app;
    }
}
