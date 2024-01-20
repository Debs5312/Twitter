using Microsoft.EntityFrameworkCore;
using Model;
using Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

Connection connection = new Connection();
builder.Services.AddDbContext<UserContext>(x => x.UseSqlServer(connection.ConnectionString));

builder.Services.AddIdentityCore<AppUser>(opt => 
{
  opt.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<UserContext>();


builder.Services.AddAuthentication();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
