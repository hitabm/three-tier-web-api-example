using Microsoft.EntityFrameworkCore;
using StudentExample.BLL.Services;
using StudentExample.DAL.Data;
using StudentExample.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer("name=StudentExampleDb"));
builder.Services.AddScoped<IStudent, StudentRepo>(); // DAL
builder.Services.AddScoped<StudentService, StudentService>(); //BLL
builder.Services.AddControllers(); // PL
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
