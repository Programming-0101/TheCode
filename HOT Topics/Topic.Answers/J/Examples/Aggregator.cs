using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.J.Examples
{
    public class Aggregator
    {
        public static double TotalItems(Numbers items)
        {
            double total = 0;
            while (items.HasNext())
                total += items.Next();
            return total;
        }

        public static double AverageItems(Numbers items)
        {
            double average, total = 0;
            int count = 0;
            while (items.HasNext())
            {
                total += items.Next();
                count++;
            }
            if (count > 0)
                average = total / count;
            else
                average = 0;
            return average;
        }

        public static double MaxValue(Numbers items)
        {
            double max = double.MinValue;
            while (items.HasNext())
            {
                double value = items.Next();
                if (max < value)
                    max = value;
            }
            return max;
        }
    }
}
