using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.T.Examples
{
    public static class TotalExtensions
    {
        public static int Total<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            int result = 0;
            foreach (var item in source)
                result += selector(item);
            return result;
        }
    }
}
