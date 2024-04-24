using Persistence.Context;
using Application.Services;
using WebApi.Extensions;
using Persistence.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigurePersistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureCorsPolicy();
builder.Services.AddSingleton<ISqlConnectionFacoty, SqlConnectionFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors();
 app.UseSwagger();
 app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
