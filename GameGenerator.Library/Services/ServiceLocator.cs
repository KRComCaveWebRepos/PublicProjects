using System;
using System.Collections.Generic;

namespace GameGenerator.Library.Services
{
    public class ServiceLocator
    {
        private static readonly IDictionary<Type, object> _services = new Dictionary<Type, object>();

        // ConfigureService
        public static void AddService<T>(object adaptee)
        {
            if (!_services.ContainsKey(typeof(T)))
            {
                _services.Add(typeof(T), adaptee);
            }
        }

        // GetService
        public static T GetService<T>()
        {
            return (T)_services[typeof(T)];
        }
    }
}
