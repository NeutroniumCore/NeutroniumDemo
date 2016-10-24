using System;
using System.Threading.Tasks;
using Neutronium.Core.Navigation;
using Neutronium.Core;
using Microsoft.Practices.ServiceLocation;
using NeutoniumDemo.Application.Ioc;

namespace NeutoniumDemo.Application.Navigation
{
    public class Navigator : INavigator
    {
        private readonly INavigationSolver _NavigationSolver;
        private IHTMLBinding _CurrentBinding;

        public event EventHandler<NavigationEvent> OnNavigate;

        internal IServiceLocator ServiceLocator { get; private set; }

        public Navigator(INavigationSolver navigationSolver, Func<INavigator, IServiceLocator> LocatorBuilder)
        {
            ServiceLocator = LocatorBuilder(this) ?? new TrivialServiceLocator();        
            _NavigationSolver = navigationSolver;
            _NavigationSolver.OnNavigate += OnNavigationSolverNavigate;
        }

        private void OnNavigationSolverNavigate(object sender, NavigationEvent e)
        {
            OnNavigate?.Invoke(this, e);
        }

        public async Task Navigate(object ViewModel, string id =null)
        {
            var oldBinding = _CurrentBinding;
            _CurrentBinding = await _NavigationSolver.NavigateAsync(ViewModel, id);
            oldBinding?.Dispose();
        }

        public async Task Navigate<T>(string id = null)
        {
            var vm = ServiceLocator.GetInstance<T>();
            await Navigate(vm, id); 
        }

        public async Task Navigate<T>(string resolutionKey, string id = null)
        {
            var vm = ServiceLocator.GetInstance<T>(resolutionKey);
            await Navigate(vm, id);
        }

        public async Task Navigate(Type type, string id = null)
        {
            var vm = ServiceLocator.GetInstance(type);
            await Navigate(vm, id);
        }

        public async Task Navigate(Type type, string resolutionKey, string id = null)
        {
            var vm = ServiceLocator.GetInstance(type, resolutionKey);
            await Navigate(vm, id);
        }
    }
}
