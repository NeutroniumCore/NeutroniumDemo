using Neutronium.Core.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeutoniumDemo.App_Start
{
    internal class ConventionRouter
    {
        private readonly INavigationBuilder _Builder;
        private readonly Func<string,string> _Pattern;

        internal ConventionRouter(INavigationBuilder builder, Func<string, string> pattern)
        {
            _Builder = builder;
            _Pattern = pattern;
        }

        internal void Register<T>(string id=null)
        {
            var name = typeof(T).Name;
            _Builder.Register<T>(_Pattern(name), id);
        }
    }
}
