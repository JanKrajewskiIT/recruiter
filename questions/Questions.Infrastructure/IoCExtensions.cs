using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Questions.Domain.Enums;
using Questions.Infrastructure.Context;

namespace Questions.Infrastructure;

public static class IoCExtensions
{
    public static IServiceCollection AddInfrastructure( this IServiceCollection services, IConfiguration configuration )
    {
        var dataSource = CreateDataSource( configuration );

        services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql( dataSource ) );
        
        return services;
    }

    private static NpgsqlDataSource CreateDataSource( IConfiguration configuration )
    {
        var connectionString = configuration.GetConnectionString( "Questions" )!;
        var dataSourceBuilder = new NpgsqlDataSourceBuilder( connectionString );

        dataSourceBuilder.EnableDynamicJson();
        dataSourceBuilder.EnableUnmappedTypes();
        dataSourceBuilder.EnableRecordsAsTuples();
        dataSourceBuilder.EnableParameterLogging(); // Should be used only on dev env

        dataSourceBuilder.MapEnum<DictionaryKey>();
        dataSourceBuilder.MapEnum<OfferStatus>();

        return dataSourceBuilder.Build();
    }

    public static async Task MigrateDatabase( this IServiceProvider services, CancellationToken cancellationToken )
    {
        using var scope = services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        if (dbContext is not null && dbContext.Database.GetPendingMigrations().Any())
        {
            await dbContext.Database.MigrateAsync( cancellationToken );

            if (dbContext.Database.GetDbConnection() is NpgsqlConnection npgsqlConnection)
            {
                try
                {
                    await npgsqlConnection.ReloadTypesAsync();
                }
                finally
                {
                    await npgsqlConnection.CloseAsync();
                }
            }
        }
    }
}
