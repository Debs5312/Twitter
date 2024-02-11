using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.ProfileMapper;
using TweetAPI.QueryCommandHandler;

namespace TweetAPI.Controllers
{
    [AllowAnonymous]
    public class TweetApiController : BaseAPIController
    {

        [HttpGet] // -> tweet/TweetApi
        public async Task<IActionResult> GetAllTweets(CancellationToken ct)
        {
            //cancellation token is added to handle a scenario where background process will stop in case of 
            //shutting down system from users end or close browser unexpectedly or unusual netowrk connection.
            var allTweets = await Mediator.Send(new GetTweetsHandler.Query(), ct);
            if(allTweets.Count() > 0) return Ok(allTweets);
            else return BadRequest();
        }

        [HttpGet("{id}")] //  -> tweet/TweetApi/dskfhkjf
        public async Task<IActionResult> GetSingleTweet(Guid id, CancellationToken ct)
        {
            var item = new GetSingleTweetHandler.Query { Id = id };
            var tweet = await Mediator.Send(item);
            if(tweet != null) return Ok(tweet);
            else return NotFound();
        }

        [HttpPost("add")] //  -> tweet/TweetApi/add
        public async Task<IActionResult> AddNewTweet([FromBody] TweetCreateProfile tweetProfile, CancellationToken ct)
        {
            var newTweet = new AddTweet.Command{ NewTweet = tweetProfile};
            var content = await Mediator.Send(newTweet, ct);
            if(content != null) return StatusCode(201, content);
            else return StatusCode(500);
        }

        [HttpPut("Edit/{id}")] //  -> tweet/TweetApi/Edit/kdfkdfd
        public async Task<IActionResult> EditTweet(Guid id, [FromBody]TweetUpdateProfile tweet, CancellationToken ct)
        {
            var updateContent = new UpdateTweet.Command{UpdatedTweet = tweet, Id = id};
            var content = await Mediator.Send(updateContent, ct);
            if(content != null) return Ok(content);
            else return StatusCode(500);
        }

        [HttpDelete("Delete/{id}")] //  -> tweet/TweetApi/Delete/kdfkdfd
        public async Task<IActionResult> RemoveTweet(Guid id, CancellationToken ct)
        {
            var tweetID = new DeleteTweet.Command{ Id = id };
            var value = await Mediator.Send(tweetID, ct);
            if(value == 0) return NotFound(); 
            return Ok();
        }
    }
}