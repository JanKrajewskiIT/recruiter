using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Questions.Api.Configuration;

internal static class SwaggerExtensions
{
    internal static JsonStringEnumConverter JsonConverter = new( JsonNamingPolicy.CamelCase, false );

    internal static IServiceCollection AddSwaggerWithAuth( this IServiceCollection services, KeycloakOptions keycloakOptions )
    {
        services.AddSwaggerGen( config => config.AddSwaggerAuth( keycloakOptions ) );
        services.Configure<JsonOptions>( options => options
            .JsonSerializerOptions
            .Converters
            .Add( JsonConverter ) );

        return services;
    }

    internal static IApplicationBuilder UseSwaggerWithAuth( this IApplicationBuilder app, KeycloakOptions keycloakOptions )
    {
        app.UseSwagger();
        app.UseSwaggerUI( options => options.UseSwaggerAuth( keycloakOptions ) );

        return app;
    }
}
