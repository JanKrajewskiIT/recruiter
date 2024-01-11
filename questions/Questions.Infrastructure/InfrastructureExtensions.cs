using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Questions.Infrastructure.Context;

namespace Questions.Infrastructure;

public static class InfrastructureExtensions
{
    public static IServiceCollection AddInfrastructure( this IServiceCollection services )
    {
        services.AddDbContext<ApplicationDbContext>(
            options => options.UseNpgsql(
                "name=ConnectionStrings:Questions"/*,
                x => x.MigrationsAssembly( "Questions.Infrastructure" )*/ ) );

        return services;
    }
}
