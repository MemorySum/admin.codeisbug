using CodeIsBug.Admin.Common.Config;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json")
                            .Build();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<DBConfig>(configuration.GetSection("ConnectionStrings:CodeIsBug.Admin"));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();

app.MapControllers();

app.Run();
