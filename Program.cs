using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();

// Get connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register DbContext with PostgreSQL
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));

var app = builder.Build();

app.Logger.LogInformation("Environment: {Env}", app.Environment.EnvironmentName);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();
