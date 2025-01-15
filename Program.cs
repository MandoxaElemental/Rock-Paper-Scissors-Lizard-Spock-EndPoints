using Rock_Paper_Scissors_Lizard_Spock.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<GameplayServices>();

builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll",
    policy => {
        policy.AllowAnyOrigin() // Allows requests from any origin
            .AllowAnyMethod() // Allows any Http Request (GET, POST, PUT, etc...)
            .AllowAnyHeader(); // Allows any headers
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
