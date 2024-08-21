# MAUI.MediatR
MAUI with MediatR

Simple mediator implementation with DependencyService in MAUI.

Example:

```
public partial class MainPage : ContentPage
{
    private readonly IMediator _mediator;

    public MainPage()
    {
        InitializeComponent();

        _mediator = DependencyService.Resolve<IMediator>();
    }
}
```
