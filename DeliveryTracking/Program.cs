using DeliveryTracking.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDataBaseConfiguration(builder.Configuration);

builder.Services.AddEvolveConfiguration(builder.Configuration, builder.Environment);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
