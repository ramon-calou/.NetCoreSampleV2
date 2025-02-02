
using DotnetCore.Sample.Core.Jwt;
using DotnetCore.Sample.Core.Middleware;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.Core.Settings;
using DotnetCore.Sample.Repository.UnitOfWork;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Bind JWT settings from appsettings.json
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
builder.Services.AddSingleton<IJwtSettings>(sp => sp.GetRequiredService<IOptions<JwtSettings>>().Value);

// Add JWT Authentication to the pipeline
builder.Services.AddJwtAuthentication(builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>());

// Registrando o UnitOfWork e ClienteService
builder.Services.AddScoped<IUnitOfWork, SampleUnitOfWork>();
builder.Services.AddScoped<ITokenService, TokenService>();
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
