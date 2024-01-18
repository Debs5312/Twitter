using Microsoft.EntityFrameworkCore;
using Persistance;
using TweetAPI.QueryCommandHandler;
using TweetAPI.Repository;
using TweetAPI.Repository.IRepository;
using TweetAPI.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TweetContext>(opt => 
{
  opt.UseSqlServer(builder.Configuration.GetConnectionString("dbconn"));
});
builder.Services.AddScoped<ITweetRepository, TweetRepository>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetTweetsHandler.Handler).Assembly));
builder.Services.AddAutoMapper(typeof(MappingPrifiles).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
