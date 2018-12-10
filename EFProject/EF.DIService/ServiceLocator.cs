
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DIService
{
    public static class ServiceLocator
    {
        private static IDictionary<Type, Type> typeMatching = new Dictionary<Type, Type>();

        public static void Register(Type sourceType, Type destType)
        {
            typeMatching.Add(sourceType, destType);
        }
 
        public static T CreateInstance<T>() where T : class
        {
            return Activator.CreateInstance(typeMatching[typeof(T)]) as T;
        }
    }
}
