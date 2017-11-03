using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.ServiceLocation;

namespace NeutroniumDemo.Application.Ioc
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
