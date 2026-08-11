using DeliveryTracking.Configurations;
using DeliveryTracking.GenericRepository;
using DeliveryTracking.Repositories;
using DeliveryTracking.Repositories.Impl;
using DeliveryTracking.Service;
using DeliveryTracking.Service.Impl;

var builder = WebApplication.CreateBuilder(args);

builder.AddSeriLogging();
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDataBaseConfiguration(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfiguration();

builder.Services.AddEvolveConfiguration(builder.Configuration, builder.Environment);

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepositories<>));

builder.Services.AddScoped<IEmployeeService, EmployeeServiceImpl>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddScoped<IEpiService, EpiServiceImpl>();
builder.Services.AddScoped<IEpiRepository, EpiRepository>();

builder.Services.AddScoped<IDeliveryService, DeliveryServiceImpl>();
builder.Services.AddScoped<IDeliveryRepository, DeliveryRepository>();

    var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseSwaggerSpecification();

app.Run();
