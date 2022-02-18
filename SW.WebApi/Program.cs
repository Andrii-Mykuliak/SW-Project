using Microsoft.EntityFrameworkCore;
using SW.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<SWContext>(service =>
    new SWContext(builder.Configuration.GetConnectionString("SWDatabase")));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>(service => new UnitOfWork(service.GetService<SWContext>()));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var service = app.Services.GetService<SWContext>();
service.Database.Migrate();

/*
var swConnectionString = builder.Configuration.GetConnectionString("SWDatabase");

var swContext = new SWContext(swConnectionString);

swContext.Database.Migrate();*/


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
