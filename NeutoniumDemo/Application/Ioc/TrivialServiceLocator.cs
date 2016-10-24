using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeutoniumDemo.Application.Ioc
{
    public class TrivialServiceLocator : ServiceLocatorImplBase, IServiceLocator
    {
        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            return Enumerable.Empty<object>();
        }

        protected override object DoGetInstance(Type serviceType, string key)
        {
            return Activator.CreateInstance(serviceType);
        }
    }
}
