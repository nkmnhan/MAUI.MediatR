using MediatR;
using System.Diagnostics;

namespace MAUI.MediatR.Core.Commands.CommandHandlers
{
    public class ExampleCommandHandler : IRequestHandler<ExampleCommand, bool>
    {
        public Task<bool> Handle(ExampleCommand request, CancellationToken cancellationToken)
        {
            try
            {
                MainPage.Count = 0;
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return Task.FromResult(false);
            }
        }
    }
}
