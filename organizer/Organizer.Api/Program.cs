using Extensions.Api;
using Organizer.Api.Endopoints;
using Organizer.Application;
using Organizer.Infrastructure;

var builder = WebApplication.CreateBuilder( args );

var keycloakSection = builder.Configuration.GetRequiredSection( "Keycloak" );
var connectionString = builder.Configuration.GetConnectionString( "Organizer" )!;

builder.Services.AddCommonConfiguration( keycloakSection );
builder.Services.AddApplication( connectionString );

var app = builder.Build();

app.UseCommonConfiguration( keycloakSection );
app.MapDictionaryEndpoints();
app.MapOfferEndpoints();

await app.Services.MigrateDatabase( CancellationToken.None );

app.Run();
