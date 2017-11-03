using System;
using Microsoft.Practices.ServiceLocation;
using Neutronium.Core.Navigation;
using NeutroniumDemo.Application.Navigation;

namespace NeutroniumDemo.Application
{
    public class ApplicationViewModel<TMenu> 
    {
        private readonly Navigator _Navigator;
        private readonly IServiceLocator _Locator;

        public TMenu Menu { get; }

        public ApplicationViewModel(INavigationSolver solver, Func<INavigator, IServiceLocator> locatorBuilder)
        {
            _Navigator = new Navigator(solver, locatorBuilder);
            _Locator = _Navigator.ServiceLocator;
            Menu = _Locator.GetInstance<TMenu>();
        }
    }
}
