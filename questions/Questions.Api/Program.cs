using MediatR;
using Questions.Application;
using Questions.Application.Queries;
using Questions.Infrastructure;

var builder = WebApplication.CreateBuilder( args );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGroup( "/categories" )
    .MapGet( "/", async ( IMediator mediator ) => await mediator.Send( new GetCategoriesQuery() ) )
    .WithName( "GetCategories" )
    .WithOpenApi();

app.Services.MigrateDatabase();

app.Run();
