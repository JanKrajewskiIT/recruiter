using MediatR;
using Questions.Api.Endopoints;
using Questions.Api.Extensions;
using Questions.Api.Middlewares;
using Questions.Application;
using Questions.Application.Queries;
using Questions.Infrastructure;

var builder = WebApplication.CreateBuilder( args );

builder.Services.AddSwagger();
builder.Services.AddAuth();
builder.Services.AddAllCors();
builder.Services.AddProblemDetails();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplication();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
}

app.UseAuth();
app.UseAllCors();
app.UseHttpsRedirection();
app.UseMiddleware<ExceptionMiddleware>();

app.MapCategoriesEndpoints();

app.Services.MigrateDatabase();

app.Run();
