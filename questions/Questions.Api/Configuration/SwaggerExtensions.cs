namespace Questions.Api.Configuration;

internal static class SwaggerExtensions
{
    public static IServiceCollection AddSwaggerWithAuth( this IServiceCollection services, KeycloakOptions keycloakOptions )
    {
        services.AddSwaggerGen( config => config.AddSwaggerAuth( keycloakOptions ) );

        return services;
    }

    public static IApplicationBuilder UseSwaggerWithAuth( this IApplicationBuilder app, KeycloakOptions keycloakOptions )
    {
        app.UseSwagger();
        app.UseSwaggerUI( options => options.UseSwaggerAuth( keycloakOptions ) );

        return app;
    }
}
