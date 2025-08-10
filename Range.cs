using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) < 0)
            {
                Min = min;
                Max = max;
            }

        }
    }
}
