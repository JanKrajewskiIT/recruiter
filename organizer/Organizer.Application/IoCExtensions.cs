using Microsoft.Extensions.DependencyInjection;
using Organizer.Application.Queries;
using Organizer.Infrastructure;

namespace Organizer.Application;

public static class IoCExtensions
{
    public static IServiceCollection AddApplication( this IServiceCollection services, string connectionString )
    {
        services.AddInfrastructure( connectionString );
        services.AddMediatR( config => config.RegisterServicesFromAssemblyContaining<GetOffersQueryHandler>() );

        return services;
    }
}
