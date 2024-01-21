using Questions.Api.Endopoints;
using Questions.Api.Extensions;
using Questions.Api.Handlers;
using Questions.Application;
using Questions.Infrastructure;

var builder = WebApplication.CreateBuilder( args );

builder.Services.AddSwagger();
builder.Services.AddAuth();
builder.Services.AddAllCors();
builder.Services.AddProblemDetails();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplication();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddExceptionHandler<ValidationExceptionHandler>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
}

app.UseAuth();
app.UseAllCors();
app.UseHttpsRedirection();
app.UseExceptionHandler();

app.MapCategoriesEndpoints();

app.Services.MigrateDatabase();

app.Run();
