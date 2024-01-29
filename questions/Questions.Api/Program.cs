using Extensions.Api;
using Questions.Api.Endopoints;
using Questions.Application;
using Questions.Infrastructure;

var builder = WebApplication.CreateBuilder( args );

var keycloakSection = builder.Configuration.GetRequiredSection( "Keycloak" );
var connectionString = builder.Configuration.GetConnectionString( "Questions" )!;

builder.Services.AddCommonConfiguration( keycloakSection );
builder.Services.AddApplication( connectionString );

var app = builder.Build();

app.UseCommonConfiguration( keycloakSection );

app.MapCategoryEndpoints();
app.MapDictionaryEndpoints();
app.MapOfferEndpoints();
app.MapQuestionEndpoints();

await app.Services.MigrateDatabase( CancellationToken.None );

app.Run();
