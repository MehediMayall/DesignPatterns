using CqrsWithEvents;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddTransient<IReadOrderRepository, ReadOrderRepository>();
builder.Services.AddTransient<IWriteOrderRepository, WriteOrderRepository>();
builder.Services.AddCommandHandlers(typeof(Program));
builder.Services.AddQueryHandlers(typeof(Program));

builder.Services.AddDbContext<AppDbContext>(options =>{
    options.UseSqlite(builder.Configuration["ConnectionStrings:local"]);
});

var app = builder.Build();

using var serviceScope = app.Services.CreateScope();
var dbContext = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
await dbContext.Database.MigrateAsync();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.AddOrdersEndpoints();


app.Run();

