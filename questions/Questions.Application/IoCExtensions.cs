using Microsoft.Extensions.DependencyInjection;
using Questions.Application.Queries;
using Questions.Infrastructure;

namespace Questions.Application;

public static class IoCExtensions
{
    public static IServiceCollection AddApplication( this IServiceCollection services, string connectionString )
    {
        services.AddInfrastructure( connectionString );
        services.AddMediatR( config => config.RegisterServicesFromAssemblyContaining<GetQuestionsQueryHandler>() );

        return services;
    }
}
