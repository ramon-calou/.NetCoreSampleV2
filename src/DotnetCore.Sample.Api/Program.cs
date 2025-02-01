
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.Core.Settings;
using DotnetCore.Sample.Repository.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Registrando o UnitOfWork e ClienteService
builder.Services.AddScoped<IUnitOfWork, SampleUnitOfWork>();
builder.Services.AddSingleton<ISettings, AppSettings>();

builder.Services
	.AddControllers()
	.AddJsonOptions(
		options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
