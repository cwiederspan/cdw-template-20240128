var builder = WebApplication.CreateSlimBuilder(args);

// Read in any environment varaibles
var message = builder.Configuration.GetValue<string>("WELCOME_MESSAGE") ?? throw new ArgumentException("Must set configuration for WELCOME_MESSAGE");

Console.WriteLine($"WELCOME_MESSAGE => {message}");

// TODO: Add other dependency injection needs here

var app = builder.Build();

app.MapGet("/", () => message);

app.MapGet("/ipinfo", (HttpRequest request) => {

    var data = new {
        Ipv4Address = request.HttpContext.Connection.RemoteIpAddress?.MapToIPv4()?.ToString(),
        ForwardFor = request.Headers["X-Forwarded-For"],
        ForwardProto = request.Headers["X-Forwarded-Proto"],
        ForwardHost = request.Headers["X-Forwarded-Host"]
    };

    return data;
});

app.Run();