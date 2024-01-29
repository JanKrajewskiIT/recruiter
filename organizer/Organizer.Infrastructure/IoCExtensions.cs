using Extensions.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Organizer.Domain.Enums;
using Organizer.Infrastructure.Context;

namespace Organizer.Infrastructure;

public static class IoCExtensions
{
    public static IServiceCollection AddInfrastructure( this IServiceCollection services, string connectionString )
    {
        var dataSource = CreateDataSource( connectionString );

        services.AddDbContext<ApplicationDbContext>( options => options.UseNpgsql( dataSource ) );

        return services;
    }

    private static NpgsqlDataSource CreateDataSource( string connectionString )
    {
        var dataSourceBuilder = new NpgsqlDataSourceBuilder( connectionString );

        dataSourceBuilder.EnableDynamicJson();
        dataSourceBuilder.EnableUnmappedTypes();
        dataSourceBuilder.EnableRecordsAsTuples();
        dataSourceBuilder.EnableParameterLogging(); // Should be used only on dev env

        dataSourceBuilder.MapEnum<DictionaryKey>();
        dataSourceBuilder.MapEnum<OfferStatus>();

        return dataSourceBuilder.Build();
    }

    public static Task MigrateDatabase( this IServiceProvider services, CancellationToken cancellationToken )
        => services.MigrateDatabase<ApplicationDbContext>( cancellationToken );
}
