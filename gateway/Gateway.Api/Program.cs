using Extensions.Api;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder( args );

var keycloakSection = builder.Configuration.GetRequiredSection( "Keycloak" );
builder.Services.AddCommonConfiguration( keycloakSection );

builder.Configuration.AddJsonFile( "ocelot.json", optional: false, reloadOnChange: true );
builder.Services.AddOcelot( builder.Configuration );

var app = builder.Build();

app.UseCommonConfiguration( keycloakSection );

await app.UseOcelot();
await app.RunAsync();