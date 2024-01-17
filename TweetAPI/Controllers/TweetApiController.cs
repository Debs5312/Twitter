using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace TweetAPI.Controllers
{
    public class TweetApiController : BaseAPIController
    {
        private readonly TweetContext _context;
        public TweetApiController(TweetContext context)
        {
            _context = context;  
        }

        [HttpGet] // -> tweet/TweetApi
        public async Task<IActionResult> GetAllTweets(CancellationToken ct)
        {
            var allTweets = await _context.Tweets.ToListAsync();
            return Ok(allTweets);
        }

        [HttpGet("{id}")] //  -> tweet/TweetApi/dskfhkjf
        public async Task<IActionResult> GetSingleTweet(Guid id, CancellationToken ct)
        {
            var tweet = await _context.Tweets.FindAsync(id);
            return Ok(tweet);
        }
    }
}