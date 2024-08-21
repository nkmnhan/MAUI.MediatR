using MediatR;
using Microsoft.Maui.Controls.Internals;
using System.Reflection;

namespace MAUI.MediatR.Core.Extensions
{
    public static class ServiceExtension
    {
        public static void AddMediatR()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var mediator = serviceProvider.GetService<IMediator>();
            DependencyResolver.ResolveUsing(serviceProvider.GetService);
        }
    }
}
