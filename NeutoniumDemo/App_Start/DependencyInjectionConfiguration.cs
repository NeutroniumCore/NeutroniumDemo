using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using NeutoniumDemo.Application.Navigation;
using Ninject;

namespace NeutoniumDemo.App_Start
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceLocator Register(INavigator navigator)
        {
            IKernel kernel = new StandardKernel();
            RegisterDependency(kernel, navigator);
            return new NinjectServiceLocator(kernel);
        }

        public static void RegisterDependency(IKernel kernel, INavigator navigator)
        {
            kernel.Bind<INavigator>().ToConstant(navigator);
        }
    }
}
