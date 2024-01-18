using MediatR;
using Model;
using TweetAPI.Repository.IRepository;

namespace TweetAPI.QueryCommandHandler
{
    public class GetSingleTweetHandler
    {
        public class Query : IRequest<Tweet> {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Tweet>
        {
            private readonly ITweetRepository _repo;
            public Handler(ITweetRepository repo)
            {
                _repo = repo;
            }
            public async Task<Tweet> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    
                    if(cancellationToken.IsCancellationRequested)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                    }
                    
                }
                catch (Exception e)
                { 
                    Console.WriteLine($"{e} thrown with message: {e.Message}");
                }
                return await _repo.getSingleTweet(request.Id);
            }
        }

    }
}