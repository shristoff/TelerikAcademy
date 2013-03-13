/* 2.Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExtensionMethods
{
    class IEnumerableExtensions
    { //Sum of the elements of enumerable generic collection
        public static T Sum<T>(this IEnumerable<T> enumer)
            where T: struct
        {
            if (enumer == null)
                throw new ArgumentNullException("The collection should have at least one element");
            T sum = default(T);
            foreach (T item in enumer)
            {
                sum = (dynamic)sum + item;
            }
            return sum;
        }
        //Product of the elements of enumerable generic collection
        public static T Product<T>(this IEnumerable<T> enumer)
            where T : struct
        {
            if (enumer == null)
                throw new ArgumentNullException("The collection should have at least one element");
            T product = (dynamic)1;
            foreach (T item in enumer)
            {
                product = (dynamic)product*item;
            }
            return product;
        }
        //Finds min element
        public static T Min<T>(this IEnumerable<T> enumer)
            where T : IComparable<T>
        {
            if (enumer == null)
                throw new ArgumentNullException("The collection should have at least one element");
            T min = enumer.First<T>();
            foreach (T item in enumer)
            {
                if (item.CompareTo(min) < 0)
                    min = item;
            }
            return min;
        }
        //Finds max element
        public static T Max<T>(this IEnumerable<T> enumer)
            where T : IComparable<T>
        {
            if (enumer == null)
                throw new ArgumentNullException("The collection should have at least one element");
            T max = enumer.First<T>();
            foreach (T item in enumer)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
        //Finds average value
        public static T Average<T>(this IEnumerable<T> enumer)
            where T : struct
        {
            if (enumer == null)
                throw new ArgumentNullException("The collection should have at least one element");
            T sum = default(T);
            ulong numberOfElements = 0;
            foreach (T item in enumer)
            {
                sum = (dynamic)sum + item;
                numberOfElements = numberOfElements + 1;
            }
            return (dynamic)sum/numberOfElements;
        }
    }
}
