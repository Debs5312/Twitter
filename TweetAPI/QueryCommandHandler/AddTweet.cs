using MediatR;
using Model;
using Model.ProfileMapper;
using TweetAPI.Repository.IRepository;

namespace TweetAPI.QueryCommandHandler
{
    public class AddTweet
    {
        public class Command : IRequest<Tweet> {
            public TweetCreateProfile NewTweet { get; set; }
        }

        public class Handler : IRequestHandler<Command, Tweet>
        {
            private readonly ITweetRepository _repo;
            
            public Handler(ITweetRepository repo)
            {
                _repo = repo; 
            }

            public async Task<Tweet> Handle(Command request, CancellationToken cancellationToken)
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
                return await _repo.createTweet(request.NewTweet);
            }

        }
    }
}