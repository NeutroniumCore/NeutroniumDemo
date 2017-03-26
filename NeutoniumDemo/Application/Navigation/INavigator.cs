using Neutronium.Core.Navigation;
using System;
using System.Threading.Tasks;

namespace NeutoniumDemo.Application.Navigation
{
    public interface INavigator
    {
        Task Navigate(object ViewModel, string id = null);

        Task Navigate<T>(NavigationContext<T> navigate = null);

        Task Navigate(Type type, NavigationContext context = null);

        event EventHandler<NavigationEvent> OnNavigate;
    }
}
