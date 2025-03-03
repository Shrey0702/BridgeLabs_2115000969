using BusinessLayer;
using BusinessLayer.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RepositoryLayer;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRergistrationBL, UserRegistrationBL>();
builder.Services.AddScoped<IUserRegistrationRL, UserRegistrationRL>();//object of class is created and passed to interface

// for NLOGGING
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

//Works with Dependency Injection (DI)

//builder.Services.AddDbContext<RegistrationAppContext>(options =>
//options.UseSqlServer("YourConnectionString"));
var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<RegistrationAppContext>(options =>
    options.UseSqlServer(connectionString));

// After this open package manager console ->
//Add-Migration InitialMigration
//Update-Database

// Add swagger to container
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();//reponsible for the colorfulness

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();