using Microsoft.EntityFrameworkCore;
using Model;

namespace Persistance
{
    public class TweetContext : DbContext
    {
        public TweetContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tweet>().HasData(
                new Tweet {
                    Id= Guid.NewGuid(),
                    Title= "Indian GDP",
                    Tweetcontext= "Indian will be 3rd Largest in terms of nominal GDP aroung 2028",
                    Category= "Economy",
                    Date= DateTime.Now.AddMonths(-2),
                    ImagePath="india.jpg"
                },
                new Tweet {
                    Id= Guid.NewGuid(),
                    Title= "Indian Forign Policy",
                    Tweetcontext= "Indian foriegn minister S. Jaisankar build Indian Stature to global platform, ensuring Indian soft power.",
                    Category= "Geopilitics",
                    Date= DateTime.Now.AddMonths(-4),
                    ImagePath="S_Jaisankar.jpg"
                },
                new Tweet {
                    Id= Guid.NewGuid(),
                    Title= "Indian Cricket",
                    Tweetcontext= "The IPL is the most-popular cricket league in the world; in 2014, it was ranked sixth by average attendance among all sports leagues.In 2010, the IPL became the first sporting event to be broadcast live on YouTube.Many domestic cricket and other sport's league started in India inspiring from the huge success of the IPL.The brand value of the league in 2022 was ₹90,038 crore (US$11 billion).",
                    Category= "Sports",
                    Date= DateTime.Now.AddHours(-2),
                    ImagePath="IPL.jpg"
                }
            );
        }

        public DbSet<Tweet> Tweets { get; set; }
        
    }
}