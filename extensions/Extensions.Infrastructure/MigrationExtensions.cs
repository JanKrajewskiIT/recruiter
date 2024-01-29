using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace Extensions.Infrastructure;

public static class MigrationExtensions
{
    public static async Task MigrateDatabase<TContext>( this IServiceProvider services, CancellationToken cancellationToken )
        where TContext : DbContext
    {
        using var scope = services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<TContext>();

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
