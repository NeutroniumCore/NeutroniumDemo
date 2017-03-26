using System;

namespace NeutoniumDemo.Application.Navigation
{
    public class NavigationContext
    {
        public string ResolutionKey { get; set; }
        public string Id { get; set; }
    }

    public class NavigationContext<T> : NavigationContext
    {
        public Action<T> BeforeNavigate { get; set; }
    }
}
