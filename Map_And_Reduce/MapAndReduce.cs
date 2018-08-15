using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_And_Reduce
{
    static class MapAndReduce
    {
        public static Result Reduce<T, Result>(this IEnumerable<T> list, Func<T, Result, Result> func, Result value)
        {
            Result val = value;

            foreach (T item in list)
            {
                val = func(item, val);
            }

            return val;
        }

        public static List<Result> Map<T, Result>(this List<T> l, Func<T, Result> func)
        {
            return l.Reduce((x, list) => { list.Add(func(x)); return list; }, new List<Result>());
        }
    }
}
