using LIS.API.Extensions;
using LIS.API.Middleware;
using LIS.Application.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

// Register Application layer services
builder.Services.AddApplication();

builder.Services.AddSwaggerDocumentation();

var app = builder.Build();


// Configure HTTP request pipeline

app.UseSwagger();
app.UseSwaggerUI();



app.UseHttpsRedirection();


// Global exception handling
app.UseMiddleware<GlobalExceptionMiddleware>();


// Map API Controllers
app.MapControllers();


app.Run();