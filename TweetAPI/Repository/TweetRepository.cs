using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.ProfileMapper;
using Persistance;
using TweetAPI.Repository.IRepository;

namespace TweetAPI.Repository
{
    public class TweetRepository : ITweetRepository
    {
        private readonly TweetContext _context;
        private readonly IMapper _mapper;
        public TweetRepository(TweetContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Tweet> createTweet(TweetCreateProfile content)
        {
            Tweet tweet = new Tweet{};
            tweet.Id = Guid.NewGuid();
            tweet.Date = DateTime.Now;
            _mapper.Map(content, tweet);
            await _context.Tweets.AddAsync(tweet);
            await _context.SaveChangesAsync();
            return tweet;
        }

        public async Task<int> deleteContent(Guid id)
        {
            var content = await _context.Tweets.FindAsync(id);
            if(content == null) return 0;
            _context.Tweets.Remove(content);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Tweet>> getAllTweets()
        {
            return await _context.Tweets.ToListAsync();
        }

        public async Task<Tweet> getSingleTweet(Guid id)
        {
            return await _context.Tweets.FindAsync(id);
        }

        public async Task<Tweet> updateTweet(TweetUpdateProfile tweet, Guid id)
        {
            Tweet item = await _context.Tweets.FindAsync(id);
            item.Date = DateTime.Now;
            _mapper.Map(tweet, item);
            await _context.SaveChangesAsync();
            return item;
        }
    }
}