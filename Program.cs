var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/hello", (string name) =>
{
    var response = new
    {
        message = $"Hello, {name}!",
        timestamp = DateTime.UtcNow
    };

    return Results.Json(response);
});

app.Run();