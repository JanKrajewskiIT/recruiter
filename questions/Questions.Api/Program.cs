using Questions.Api.Configuration;
using Questions.Api.Endopoints;
using Questions.Api.Handlers;
using Questions.Application;
using Questions.Infrastructure;

var builder = WebApplication.CreateBuilder( args );

var keycloakOptions = builder.Configuration
    .GetSection( AuthExtensions.KeycloakConfigurationKey )
    .Get<KeycloakOptions>()!;

builder.Services.AddSwaggerWithAuth( keycloakOptions );
builder.Services.AddAuth( keycloakOptions );
builder.Services.AddAllCors();
builder.Services.AddProblemDetails();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplication( builder.Configuration );
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddExceptionHandler<ValidationExceptionHandler>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerWithAuth( keycloakOptions );
}

app.UseAuth();
app.UseAllCors();
app.UseHttpsRedirection();
app.UseExceptionHandler();

app.MapCategoryEndpoints();
app.MapDictionaryEndpoints();
app.MapOfferEndpoints();
app.MapQuestionEndpoints();

await app.Services.MigrateDatabase(CancellationToken.None);

app.Run();
