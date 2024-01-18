using MediatR;
using TweetAPI.Repository.IRepository;

namespace TweetAPI.QueryCommandHandler
{
    public class DeleteTweet
    {
        public class Command : IRequest<int> {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, int> 
        {
            private readonly ITweetRepository _repo;
            public Handler(ITweetRepository repo)
            {
                _repo = repo;
            }

            public async Task<int> Handle(Command request, CancellationToken cancellationToken) 
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

                return await _repo.deleteContent(request.Id);
            }
        }    
    }
}