using System;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using Neutronium.Core;
using Neutronium.Core.Navigation;
using NeutroniumDemo.Application.Ioc;

namespace NeutroniumDemo.Application.Navigation
{
    public class Navigator : INavigator
    {
        private readonly INavigationSolver _NavigationSolver;
        private IHtmlBinding _CurrentBinding;

        internal IServiceLocator ServiceLocator { get; }

        public event EventHandler<NavigationEvent> OnNavigate;

        public Navigator(INavigationSolver navigationSolver, Func<INavigator, IServiceLocator> locatorBuilder)
        {
            ServiceLocator = locatorBuilder(this) ?? new TrivialServiceLocator();
            _NavigationSolver = navigationSolver;
            _NavigationSolver.OnNavigate += OnNavigationSolverNavigate;
        }

        private void OnNavigationSolverNavigate(object sender, NavigationEvent e)
        {
            OnNavigate?.Invoke(this, e);
        }

        public async Task Navigate(object viewModel, string id = null)
        {
            var oldBinding = _CurrentBinding;
            _CurrentBinding = await _NavigationSolver.NavigateAsync(viewModel, id);
            oldBinding?.Dispose();
        }

        public async Task Navigate<T>(NavigationContext<T> context = null)
        {
            var resolutionKey = context?.ResolutionKey;
            var vm = (resolutionKey == null) ? ServiceLocator.GetInstance<T>() : ServiceLocator.GetInstance<T>(resolutionKey);
            context?.BeforeNavigate(vm);
            await Navigate(vm, context?.Id);
        }

        public async Task Navigate(Type type, NavigationContext context = null)
        {
            var resolutionKey = context?.ResolutionKey;
            var vm = (resolutionKey == null) ? ServiceLocator.GetInstance(type) : ServiceLocator.GetInstance(type, resolutionKey);
            await Navigate(vm, context?.Id);
        }
    }
}
