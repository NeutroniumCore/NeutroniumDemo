using Microsoft.Practices.ServiceLocation;
using NeutoniumDemo.Application.Navigation;
using Neutronium.Core.Navigation;
using System;

namespace NeutoniumDemo.Application
{
    public class ApplicationViewModel<TMenu> 
    {
        private readonly Navigator _Navigator;
        private readonly IServiceLocator _Locator;

        public TMenu Menu { get; private set; }

        public ApplicationViewModel(INavigationSolver solver, Func<INavigator, IServiceLocator> LocatorBuilder)
        {
            _Navigator = new Navigator(solver, LocatorBuilder);
            _Locator = _Navigator.ServiceLocator;
            Menu = _Locator.GetInstance<TMenu>();
        }
    }
}
