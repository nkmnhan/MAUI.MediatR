using MediatR;

namespace MAUI.MediatR.Core.Queries.QueryHandlers
{
    public class ExampleQueryHandler : IRequestHandler<ExampleQuery, int>
    {
        public Task<int> Handle(ExampleQuery request, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromResult(0);
            }

            return Task.FromResult(10);
        }
    }
}
