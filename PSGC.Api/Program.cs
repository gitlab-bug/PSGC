using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PSGC.Api.Data;
using PSGC.Api.Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "PSGC Geo API",
        Description = "Simple API Implementation for Philippine Standard Geographic Code based on September 2024 Data.",
        Contact = new OpenApiContact
        {
            Name = "Ulysses Peralta",
            Email = "ulysses.peralta@gmail.com"
        }
    });
});


builder.Services.AddDbContextFactory<DataContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SQLite")));

builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddHttpClient();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = "api";
    });
}

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
