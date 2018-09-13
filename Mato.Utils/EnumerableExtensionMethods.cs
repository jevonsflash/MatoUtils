using System;
using System.Collections.Generic;

namespace Mato.Utils
{
    public static class EnumerableExtensionMethods
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            foreach (var item in source)
                action(item);

            return source;
        }
    }
}