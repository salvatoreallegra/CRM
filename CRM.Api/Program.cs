using CRM.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddSingleton<DateTimeProvider>();
builder.Services.AddSingleton<CustomerService>();

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

app.UseHttpsRedirection();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/time", () =>
{
    Console.WriteLine("***** ENDPOINT *****");
    return Results.Ok("Hello");
});

app.MapControllers();

app.Run();