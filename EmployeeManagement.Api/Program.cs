using EmployeeManagement.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
// To Swagger in api 
builder.Services.AddSwaggerGen();

//To create dbContext 
builder.Services.AddDbContext<AppliactionDbContext>(x =>
{
    x.UseSqlServer( // to tell that which database we are going to use , sql , mysql and etc.
    builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();
// To swagger api in interface  or to show swagger interface. 
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
