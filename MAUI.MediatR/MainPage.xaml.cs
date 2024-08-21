using MAUI.MediatR.Core.Commands;
using MAUI.MediatR.Core.Queries;
using MediatR;

namespace MAUI.MediatR
{
    public partial class MainPage : ContentPage
    {
        public static int Count = 0;
        private readonly IMediator _mediator;
        private CancellationTokenSource _cancellationTokenSource;
        private CancellationToken _cancellationToken;

        public MainPage()
        {
            InitializeComponent();

            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;
            _mediator = DependencyService.Resolve<IMediator>();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var result = await _mediator.Send(new ExampleQuery(), _cancellationToken);

            Count += result;

            if (result == 0)
            {
                await DisplayAlert("ExampleQuery Result", "Operation cancelled", "OK");
                return;
            }
            else
                CounterBtn.Text = Count == 0 ? $"Clicked {Count} time" : $"Clicked {Count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnCancelTokenTestingClicked(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        private async void OnResetClicked(object sender, EventArgs e)
        {
            var resetResult = await _mediator.Send(new ExampleCommand());

            if (resetResult)
                CounterBtn.Text = $"Clicked me";

            await DisplayAlert("Alert", $"ExampleCommand {resetResult}", "OK");

            _cancellationTokenSource = new();
            _cancellationToken = _cancellationTokenSource.Token;
        }
    }

}
