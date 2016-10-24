using Neutronium.Core.Navigation;
using System;
using System.Threading.Tasks;

namespace NeutoniumDemo.Application.Navigation
{
    public interface INavigator
    {
        Task Navigate(object ViewModel, string id = null);

        Task Navigate<T>(string id = null);

        Task Navigate<T>(string resolutionKey, string id = null);

        Task Navigate(Type type, string id = null);

        Task Navigate(Type type, string resolutionKey, string id = null);

        event EventHandler<NavigationEvent> OnNavigate;
    }
}
