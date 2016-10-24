using NeutoniumDemo.ViewModel;
using Neutronium.Core.Navigation;

namespace NeutoniumDemo.App_Start
{
    public static class RoutingConfiguration
    {
        public static void Register(INavigationBuilder builder)
        {
            var router = new ConventionRouter(builder, GetPath);
            router.Register<Page1ViewModel>();
            router.Register<Page2ViewModel>();
            router.Register<AboutViewModel>();
        }

        private const string ViewModel = "ViewModel";
        private static string GetPath(string type)
        {           
            if (type.EndsWith(ViewModel))
            {
                type = type.Substring(0, type.Length- ViewModel.Length);
            }

            return $"View\\{type}\\index.HTML";
        }
    }
}
