using Neutronium.Core.Navigation;

namespace NeutoniumDemo.App_Start
{
    internal class ConventionRouter
    {
        private readonly INavigationBuilder _Builder;
        private readonly string _Pattern;
        private const string ViewModel = "ViewModel";

        internal ConventionRouter(INavigationBuilder builder, string pattern)
        {
            _Builder = builder;
            _Pattern = pattern;
        }

        internal void Register<T>(string id=null)
        {
            var name = typeof(T).Name;
            if (name.EndsWith(ViewModel)) {
                name = name.Substring(0, name.Length - ViewModel.Length);
            }

            _Builder.Register<T>(string.Format(_Pattern,name), id);
        }
    }
}
