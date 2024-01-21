namespace Questions.Api.Extensions;

internal static class SwaggerExtensions
{
    public static IServiceCollection AddSwagger( this IServiceCollection services )
    {
        services.AddSwaggerGen( config => config.AddSwaggerAuth() );

        return services;
    }

    public static IApplicationBuilder UseSwagger( this IApplicationBuilder app )
    {
        app.UseSwagger();
        app.UseSwaggerUI( options => options.UseSwaggerAuth() );

        return app;
    }
}
