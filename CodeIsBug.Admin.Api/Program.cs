using System.Text.Json;
using System.Text.Json.Serialization;
using CodeIsBug.Admin.Common.Config;
using CodeIsBug.Admin.Common.Helper;
using CodeIsBug.Admin.Extension;
using SqlSugar.IOC;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json")
                            .Build();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    options.JsonSerializerOptions.Converters.Add(new DateTimeJsonConverter("yyyy-MM-dd HH:mm:ss"));
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;

});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<DBConfig>(configuration.GetSection("ConnectionStrings:CodeIsBug.Admin"));
builder.Services.AddAppService();
#region ≈‰÷√SqlSugar IOC
builder.Services.AddSqlSugar(new IocConfig
{
    ConnectionString = configuration.GetConnectionString("CodeIsBug.Admin"),
    DbType = IocDbType.MySql,
    IsAutoCloseConnection = true //◊‘∂Ø Õ∑≈
});
#endregion

//#region Autofac
//builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
//builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
//{
//    builder.RegisterModule(new AutofacModuleRegister());
//});
//#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();

app.MapControllers();

app.Run();



