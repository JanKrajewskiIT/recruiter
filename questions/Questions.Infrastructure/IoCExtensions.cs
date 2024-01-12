using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Questions.Infrastructure.Context;

namespace Questions.Infrastructure;

public static class IoCExtensions
{
    public static IServiceCollection AddInfrastructure( this IServiceCollection services )
    {
        services.AddDbContext<ApplicationDbContext>(
            options => options.UseNpgsql( "name=ConnectionStrings:Questions" ) );

        return services;
    }

    public static void MigrateDatabase( this IServiceProvider services )
    {
        using var scope = services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        if (dbContext is not null && dbContext.Database.GetPendingMigrations().Any())
        {
            dbContext.Database.Migrate();
        }
    }
}
