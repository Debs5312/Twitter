using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Persistance;
using TweetAPI.QueryCommandHandler;
using TweetAPI.Repository;
using TweetAPI.Repository.IRepository;
using TweetAPI.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(
  opt => {
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    opt.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddDbContext<TweetContext>(opt => 
{
  opt.UseSqlServer(builder.Configuration.GetConnectionString("dbconn"));
});
builder.Services.AddScoped<ITweetRepository, TweetRepository>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetTweetsHandler.Handler).Assembly));
builder.Services.AddAutoMapper(typeof(MappingPrifiles).Assembly);

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
