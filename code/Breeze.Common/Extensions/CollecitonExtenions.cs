using System.Collections.Generic;
using System.Linq;

namespace Breeze.Common.Extensions
{
    public static class CollecitonExtenions
    {
        public static List<T> SubList<T>(this IEnumerable<T> list, int fromRange, int toRange)
        {
            return new List<T>(list.Skip(fromRange).Take(toRange - fromRange));
        }
    }
}
