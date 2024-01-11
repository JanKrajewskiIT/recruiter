using MediatR;
using Questions.Api;
using Questions.Application;
using Questions.Application.Queries;

var builder = WebApplication.CreateSlimBuilder( args );

builder.Services.ConfigureHttpJsonOptions( options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert( 0, AppJsonSerializerContext.Default );
} );

/*var connectionString = builder.Configuration.GetConnectionString( "Questions" ) 
    ?? throw new NullReferenceException("");

builder.Services.AddInfrastructure( connectionString );*/
builder.Services.AddApplication();
var app = builder.Build();

var sampleTodos = new Todo[] {
    new(1, "Walk the dog"),
    new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
    new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
    new(4, "Clean the bathroom"),
    new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
};

var todosApi = app.MapGroup( "/todos" );
todosApi.MapGet( "/", () => sampleTodos );
todosApi.MapGet( "/{id}", ( int id ) =>
    sampleTodos.FirstOrDefault( a => a.Id == id ) is { } todo
        ? Results.Ok( todo )
        : Results.NotFound() );

var categoriesApi = app.MapGroup( "/categories" );
categoriesApi.MapGet( "/", async ( IMediator mediator ) =>
    await mediator.Send( new GetCategoriesQuery() ) );

app.Run();