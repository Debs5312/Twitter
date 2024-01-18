using Model;
using Model.ProfileMapper;

namespace TweetAPI.Repository.IRepository
{
    public interface ITweetRepository
    {
        Task<IEnumerable<Tweet>> getAllTweets();
        Task<Tweet> getSingleTweet(Guid id);
        Task<Tweet> createTweet(TweetCreateProfile content);
        Task<Tweet> updateTweet(TweetUpdateProfile tweet, Guid id);
        Task<int> deleteContent(Guid id);
    }
}