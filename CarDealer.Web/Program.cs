using CarDealer.Infrastructure.Data;
using CarDealer.Infrastructure.Repositories;
using CarDealer.Infrastructure.Services;
using CarDealer.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<CarDealerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// репозиторий (у тебя уже должен быть CarRepository/InquiryRepository)
builder.Services.AddScoped<IInquiryRepository, InquiryRepository>();

// сервис
builder.Services.AddScoped<IInquiryService, InquiryService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();