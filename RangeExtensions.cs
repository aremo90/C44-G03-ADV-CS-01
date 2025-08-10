using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class RangeExtensions
    {
        public static bool IsInRange<T>(this Range<T> range, T value) where T : IComparable<T>
        {
            return value.CompareTo(range.Min) >= 0 && value.CompareTo(range.Max) <= 0;
        }

        public static dynamic Length<T>(this Range<T> range) where T : IComparable<T>
        {
            return (dynamic)range.Max - (dynamic)range.Min;
        }
    }
}
