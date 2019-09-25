using System;
using System.Collections.Generic;

namespace Algs.DependencyManagement
{
    /// <summary>
    /// Implementation guidance taken from: https://rlbisbe.net/2014/08/04/creating-a-dependency-injection-engine-with-c/
    /// </summary>
    public static class Injector
    {
        private static Dictionary<Type, Type> DependencyMap = new Dictionary<Type, Type>();

        public static T Get<T> ()
        {
            var type = typeof(T);
            return (T)Get(type);
        }

        public static object Get (Type type)
        {
            var target = ResolveType(type);
            var constructor = target.GetConstructors()[0];
            var parameters = constructor.GetParameters();

            List<object> ResolvedParameters = new List<object>();

            foreach (var param in parameters)
            {
                ResolvedParameters.Add(Get(param.ParameterType));
            }

            var toret = constructor.Invoke(ResolvedParameters.ToArray());

            return toret;
        }

        private static Type ResolveType (Type type)
        {
            if (DependencyMap.ContainsKey(type))
            {
                // returns the type of object related to the interface present in the mappings
                return DependencyMap[type];
            }

            // otherwise return the interface type provided to the method as the parameter
            return type;
        }

        public static void Map<T, V> () where V : T
        {
            DependencyMap.Add(typeof(T), typeof(V));
        }

        public static void Clear ()
        {
            DependencyMap.Clear();
        }
    }
}
