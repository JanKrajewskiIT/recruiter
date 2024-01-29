using Extensions.Api.Configuration;
using Extensions.Api.Handlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Extensions.Api;

public static class ConfigurationExtensions
{
    public static IServiceCollection AddCommonConfiguration( 
        this IServiceCollection services, 
        IConfigurationSection keycloakSection )
    {
        services
            .AddOptions<KeycloakOptions>()
            .Bind( keycloakSection )
            .ValidateDataAnnotations()
            .ValidateOnStart();

        var keycloakOptions = keycloakSection.Get<KeycloakOptions>()!;

        services.AddSwaggerWithAuth( keycloakOptions );
        services.AddAuth( keycloakOptions );
        services.AddAllCors();
        services.AddProblemDetails();
        services.AddEndpointsApiExplorer();
        services.AddExceptionHandler<GlobalExceptionHandler>();
        services.AddExceptionHandler<ValidationExceptionHandler>();
        services.ConfigureHttpJsonOptions( options => options
            .SerializerOptions
            .Converters
            .Add( SwaggerExtensions.JsonConverter ) );

        return services;
    }

    public static IApplicationBuilder UseCommonConfiguration( 
        this WebApplication app,
        IConfigurationSection keycloakSection )
    {
        var keycloakOptions = keycloakSection.Get<KeycloakOptions>()!;

        if (app.Environment.IsDevelopment())
        {
            app.UseSwaggerWithAuth( keycloakOptions );
        }

        app.UseAuth();
        app.UseAllCors();
        app.UseHttpsRedirection();
        app.UseExceptionHandler();

        return app;
    }
}