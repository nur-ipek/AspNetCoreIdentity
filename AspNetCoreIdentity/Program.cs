using AspNetCoreIdentity.Models.Authentication;
using AspNetCoreIdentity.Models.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(_ => _.UseSqlServer(builder.Configuration["ConnectionStrings:SqlServerConnectionString"]));
builder.Services.AddIdentity<AppUser, AppRole > ().AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddControllers();
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
app.UseAuthentication(); // uygulamanın identity ile kimlik doğrulaması gerçekleştireceğini belirtmiş bulunmaktayız.
app.UseAuthorization();

app.MapControllers();

app.Run();
