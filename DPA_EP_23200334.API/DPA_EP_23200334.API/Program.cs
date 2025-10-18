using DPA_EP_23200334.CORE.Core.Interfaces;
using DPA_EP_23200334.CORE.Core.Services;
using DPA_EP_23200334.CORE.Infrastructure.Data;
using DPA_EP_23200334.CORE.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var _configuration = builder.Configuration;
var _connectionString = _configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<UniversidadContext>(options =>
{
    options.UseSqlServer(_connectionString);
});

builder.Services.AddTransient<ICarrerarepository, Carrerarepository>();
//builder.Services.AddTransient<ICarreraService, CarreraService>();
builder.Services.AddTransient<IEstudianteRepository, EstudianteRepository>();
//builder.Services.AddTransient<IEstudianteService, EstudianteService>(); 

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
