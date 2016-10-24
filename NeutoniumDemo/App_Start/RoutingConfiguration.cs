using NeutoniumDemo.ViewModel;
using Neutronium.Core.Navigation;

namespace NeutoniumDemo.App_Start
{
    public static class RoutingConfiguration
    {
        public static void Register(INavigationBuilder builder)
        {
            var router = new ConventionRouter(builder, @"View\{0}\index.HTML");
            router.Register<Page1ViewModel>();
            router.Register<Page2ViewModel>();
            router.Register<AboutViewModel>();
        }
    }
}
