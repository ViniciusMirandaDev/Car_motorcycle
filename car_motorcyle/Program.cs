using car_motorcyle.Context;
using car_motorcyle.Repositories;
using car_motorcyle.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Car DI
builder.Services.AddScoped<ICarEFService, CarEFService>();
builder.Services.AddScoped<ICarEFRepository, CarEFRepository>();

//Motorcycle DI
builder.Services.AddScoped<IMotorcycleDapperService, MotorcycleDapperService>();
builder.Services.AddScoped<IMotorcycleDapperRepository, MotorcycleDapperRepository>();

builder.Services.AddDbContext<CoreContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("Default");
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
