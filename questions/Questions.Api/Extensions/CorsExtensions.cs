namespace Questions.Api.Extensions;

internal static class CorsExtensions
{
    private const string allCors = "allCors";

    public static IServiceCollection AddAllCors( this IServiceCollection services )
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

    public static IApplicationBuilder UseAllCors( this IApplicationBuilder app )
    {
        app.UseCors( allCors );

        return app;
    }
}
