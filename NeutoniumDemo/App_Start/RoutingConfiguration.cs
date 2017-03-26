using NeutoniumDemo.ViewModel;
using Neutronium.Core.Navigation;
using Neutronium.Core.Navigation.Routing;

namespace NeutoniumDemo.App_Start
{
    public static class RoutingConfiguration
    {
        public static void Register(INavigationBuilder builder)
        {
            var convention = builder.GetTemplateConvention(@"View\{vm}\dist\index.HTML");
            typeof(RoutingConfiguration).GetTypesFromSameAssembly()
                                        .InNamespace("NeutoniumDemo.ViewModel")
                                        .Except(typeof(ApplicationMenuViewModel))
                                        .Register(convention);
        }
    }
}
