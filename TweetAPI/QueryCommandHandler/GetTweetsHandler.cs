using MediatR;
using Model;
using Persistance;
using TweetAPI.Repository.IRepository;

namespace TweetAPI.QueryCommandHandler
{
    public class GetTweetsHandler
    {
        public class Query : IRequest<IEnumerable<Tweet>> {}
        public class Handler : IRequestHandler<Query, IEnumerable<Tweet>>
        {
            private readonly ITweetRepository _repo;
            public Handler(ITweetRepository repo)
            {
                _repo = repo;
            }
            public async Task<IEnumerable<Tweet>> Handle(Query request, CancellationToken cancellationToken)
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
                return await _repo.getAllTweets();
            }
        }
    }
}