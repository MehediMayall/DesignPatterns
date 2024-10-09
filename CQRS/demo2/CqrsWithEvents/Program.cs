using CqrsWithEvents;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddTransient<IReadOrderRepository, ReadOrderRepository>();
builder.Services.AddTransient<IWriteOrderRepository, WriteOrderRepository>();

builder.Services.AddDbContext<AppDbContext>(options =>{
    options.UseSqlite(builder.Configuration["ConnectionStrings:local"]);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();

