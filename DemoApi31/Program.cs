using DemoApi31.Data;
using DemoApi31.Model;
using DemoApi31.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>
    (opetion => opetion.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
builder.Services.AddScoped<MainInterface<Employee>, MainRepository<Employee>>();
builder.Services.AddScoped<MainInterface<Course>, MainRepository<Course>>();
builder.Services.AddScoped<MainInterface<Certificate>,MainRepository<Certificate>>();

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
