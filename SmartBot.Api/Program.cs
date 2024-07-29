using SmartBot.Api.Configurations;
using SmartBot.Api.Providers;
using SmartBot.Common.Configuration;
using SmartBot.DataAccess.DBContext;
using SmartBot.DataAccess.Interface;
using SmartBot.DataAccess.Repositories;
using SmartBot.DataAccess.UnitOfWork;
using SmartBot.DataDto.Base;
using SmartBot.Services;
using SmartBot.Services.Permissions;
using Microsoft.EntityFrameworkCore;
using Q101.ServiceCollectionExtensions.ServiceCollectionExtensions;
using SmartBot.Api.MiddleWare;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);
var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false)
    .Build();
AppConfigs.LoadAll(config);
builder.Services.AddHttpContextAccessor();

//--register CommonDBContext
builder.Services.AddDbContext<CommonDBContext>(options =>
            options.UseSqlServer(AppConfigs.SqlConnection, options => { }),
            ServiceLifetime.Scoped
            );
builder.Services.AddTransient(typeof(ICommonRepository<>), typeof(CommonRepository<>));
builder.Services.AddTransient(typeof(ICommonUoW), typeof(CommonUoW));
//builder.Services.AddScoped(typeof(IOrderFunction), typeof(OrderFunction));

//--register Service
builder.Services.RegisterAssemblyTypesByName(typeof(IPermissionService).Assembly,
     name => name.EndsWith("Service")) // Condition for name of type
.AsScoped()
.AsImplementedInterfaces()
     .Bind();
builder.Services.AddCommonServices();
builder.Services.Configure<AppSettings>(config.GetSection("AppSettings"));

// Add services to the container.
builder.Services.AddHttpClient<IMyTypedClientServices, MyTypedClientServices>();

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.DateFormatString = "dd/MM/yyyy HH:mm:ss";
}); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSingleton<Random>();

var app = builder.Build();
StaticServiceProvider.Provider = app.Services;
app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SmartBot Api"));
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<JwtMiddleware>();

app.MapControllers();
//UpdateTimer.Init();
app.Run();

