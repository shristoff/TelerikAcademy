using System;
using System.Collections.Generic;

namespace GenericList
{
    public static class GenericListExtensionMethods
    {
        //Finds min element if the elements are comparable
        public static T Min<T>(this GenericList<T> list)
            where T : IComparable<T>
        {
            T min = list[0];
            for (int i = 1; i < list.Size; i++)
            {
                if (list[i].CompareTo(min) < 0)
                    min = list[i];
            }
            return min;
        }
        //Finds max element if the elements are comparable
        public static T Max<T>(this GenericList<T> list)
            where T : IComparable<T>
        {
            T max = list[0];
            for (int i = 1; i < list.Size; i++)
            {
                if (list[i].CompareTo(max) > 0)
                    max = list[i];
            }
            return max;
        }
    }
}
