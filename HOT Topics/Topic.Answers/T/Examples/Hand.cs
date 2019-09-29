using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.T.Examples
{
    public class Hand<TKey, TElement> : IEnumerable<TElement>, IEnumerable
    {
        public TKey Holder { get; set; }
        public IEnumerable<TElement> Items { get; set; }

        public IEnumerator<TElement> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
    public static class DealingExtensions
    {
        public static IQueryable<Hand<TKey, TElement>> Deal<TSource, TKey, TElement>(this IQueryable<TSource> source, int maxCountEach, System.Linq.Expressions.Expression<Func<TSource, TKey>> keySelector)
        {
            var result = new List<Hand<TKey, TElement>>();
            foreach(var item in source)
            {
                var nums = new int[] { 5, 2, 6, 9, 8, 1, 0, 5 };
                IEnumerable<IGrouping<int, int>> results = nums.GroupBy(x => x);
            }
            return result.AsQueryable();
        }
    }
}
