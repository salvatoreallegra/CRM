using CRM.Api;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddTransient<DateTimeProvider>();
var app = builder.Build();

app.MapGet("/time", (
    DateTimeProvider provider1,
    DateTimeProvider provider2) =>
{
    return Results.Ok(new
    {
        Provider1 = provider1.Id,
        Provider2 = provider2.Id,
        SameObject = ReferenceEquals(provider1, provider2)
    });
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
