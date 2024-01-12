using MediatR;
using Microsoft.EntityFrameworkCore;
using Questions.Api;
using Questions.Application;
using Questions.Application.Queries;
using Questions.Infrastructure.Context;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet( "/weatherforecast", () =>
{
    var forecast = Enumerable.Range( 1, 5 ).Select( index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime( DateTime.Now.AddDays( index ) ),
            Random.Shared.Next( -20, 55 ),
            summaries[ Random.Shared.Next( summaries.Length ) ]
        ) )
        .ToArray();
    return forecast;
} )
.WithName( "GetWeatherForecast" )
.WithOpenApi();

app.MapGroup( "/categories" )
    .MapGet( "/", async ( IMediator mediator ) => await mediator.Send( new GetCategoriesQuery() ) )
    .WithName( "GetCategories" )
    .WithOpenApi();

ApplyMigration();

app.Run();


void ApplyMigration()
{
    using (var scope = app.Services.CreateScope())
    {
        var _Db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        if (_Db != null)
        {
            if (_Db.Database.GetPendingMigrations().Any())
            {
                _Db.Database.Migrate();
            }
        }
    }
}