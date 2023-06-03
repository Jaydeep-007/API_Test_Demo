using Microsoft.EntityFrameworkCore;
using API_Test_Demo.Data;
using API_Test_Demo.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddDbContext<DbContextClass>
(o => o.UseInMemoryDatabase("API_Test_Demo"));

builder.Services.AddControllers();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DbContextClass>();

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
app.Environment.IsDevelopment();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
