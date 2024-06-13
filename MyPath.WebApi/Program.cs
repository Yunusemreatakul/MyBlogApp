using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using FluentValidation.AspNetCore;
using MediatR;
using MyPath.Application.Services;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using MyPath.Application.Features.CQRSMediator.Command.UserCommands;
using MyPath.Application.Interfaces;
using Persistence.Context;
using Persistence.Repository;
using Microsoft.AspNetCore.Identity;
using MyPath.Domain.Entities;
using MyPath.Application.Tools;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddScoped<MyPathContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();


// Add DbContext
builder.Services.AddDbContext<MyPathContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateAudience = true,
        ValidAudience = JwtTokenDefaults.ValidAudience,
        ValidateIssuer = true,
        ValidIssuer = JwtTokenDefaults.ValidIssuer,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});
// Add custom application services
builder.Services.AddApplicationServices(builder.Configuration);

// Add FluentValidation


builder.Services.AddControllers();
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
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
