using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1CustomLINQExtMethod
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var item in collection)
            {
                bool predicateResult = predicate(item);
                if (!predicateResult)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> func) where TSelector : IComparable
        {
            var resultCollection = new List<TSelector>();
            foreach (var item in collection)
            {
               resultCollection.Add(func(item));
            }

            var max = resultCollection[0];

            for (int i = 1; i < resultCollection.Count; i++)
            {
                if (resultCollection[i].CompareTo(max) > 0)
                {
                    max = resultCollection[i];
                }
            }

            return max;
        }
    }
   
}
