using CRM.Api;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<DateTimeProvider>();
builder.Services.AddScoped<CustomerService>();

var app = builder.Build();

app.Use(async (context, next) =>
{
    Console.WriteLine("Entering A");

    await next();

    Console.WriteLine("Leaving A");
});

app.Use(async (context, next) =>
{
    Console.WriteLine("Entering B");

    await next();

    Console.WriteLine("Leaving B");
});

app.Use(async (context, next) =>
{
    Console.WriteLine("Entering C");

    await next();

    Console.WriteLine("Leaving C");
});

app.MapGet("/time", () =>
{
    Console.WriteLine("***** ENDPOINT *****");

    return Results.Ok("Hello");
});

// Configure the HTTP app.Use(async (context, next) =>

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
