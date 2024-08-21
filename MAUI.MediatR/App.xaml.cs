using MAUI.MediatR.Core.Extensions;

namespace MAUI.MediatR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ServiceExtension.AddMediatR();
            MainPage = new AppShell();
        }
    }
}
