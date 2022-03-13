using Autofac;
using Autofac.Extensions.DependencyInjection;
using CodeIsBug.Admin.Common.Config;
using CodeIsBug.Admin.Extension;
using SqlSugar.IOC;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json")
                            .Build();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<DBConfig>(configuration.GetSection("ConnectionStrings:CodeIsBug.Admin"));

#region ≈‰÷√SqlSugar IOC
builder.Services.AddSqlSugar(new IocConfig
                             {
                                 ConnectionString = DBConfig.ConnectionString,
                                 DbType = IocDbType.MySql,
                                 IsAutoCloseConnection = true //◊‘∂Ø Õ∑≈
                             }); 
#endregion

#region Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacModuleRegister());
}); 
#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();

app.MapControllers();

app.Run();
