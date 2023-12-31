using Customer.Business.Services;
using Customer.Business.Utilities;
using Customer.Domain.Interfaces.Services;
using Customer.Domain.Interfaces.Utilities;
using Customer.Infrastructure.DbContextInformation;
using Customer.Infrastructure.Repositories;
using Customer.Infrastructure.Repositories.Interfaces;
using DigitalBanking.Common.Interfaces.Respoistory;
using DigitalBanking.Common.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddScoped<CustomerDbContext>();
builder.Services.AddDbContextPool<CustomerDbContext>(options => options.UseSqlServer(configuration["ConnectionString:CustomerDigitalBankDB"]));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.Load("Customer.Business")));

builder.Services.AddAutoMapper(Assembly.Load("Customer.Domain"));

builder.Services.AddTransient(typeof(IBaseRepository<,,>), typeof(BaseRepository<,,>));
builder.Services.AddTransient<ICustomerInformationRespository, CustomerInformationRepository>();
builder.Services.AddTransient<ICustomerSecurityRespository, CustomerSecurityRepository>();

builder.Services.AddSingleton<ICryptographyUtility, CryptographyUtility>();
builder.Services.AddSingleton<ITokenService, TokenService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
