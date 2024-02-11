using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Model;
using Persistance;
using UserAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

Connection connection = new Connection();
builder.Services.AddDbContext<UserContext>(x => x.UseSqlServer(connection.ConnectionString));

builder.Services.AddIdentityCore<AppUser>(opt => 
{
  opt.Password.RequireNonAlphanumeric = false;
  opt.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<UserContext>();

var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"]));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt => 
{
  opt.TokenValidationParameters = new TokenValidationParameters
  {
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = key,
    ValidateIssuer = false,
    ValidateAudience = false
  };

});

builder.Services.AddScoped<TokenService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();
app.UseCors(opt =>
{
    opt.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins("http://localhost:3000");
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
