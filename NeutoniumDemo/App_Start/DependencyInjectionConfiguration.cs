using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using NeutroniumDemo.Application.Navigation;
using Ninject;

namespace NeutroniumDemo
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceLocator Register(INavigator navigator)
        {
            IKernel kernel = new StandardKernel(new NinjectSettings { UseReflectionBasedInjection = true });
            RegisterDependency(kernel, navigator);
            return new NinjectServiceLocator(kernel);
        }

        public static void RegisterDependency(IKernel kernel, INavigator navigator)
        {
            kernel.Bind<INavigator>().ToConstant(navigator);
        }
    }
}
