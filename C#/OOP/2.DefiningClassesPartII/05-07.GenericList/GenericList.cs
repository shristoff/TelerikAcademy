/*  5.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
Implement methods for adding element, accessing element by index, removing element by index, inserting element at 
given position, clearing the list, finding element by its value and ToString(). 
Check all input parameters to avoid accessing elements at invalid positions.
    6.Implement auto-grow functionality: when the internal array is full, 
create a new array of double size and move all elements to it.
    7.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>. 
You may need to add a generic constraints for the type T.*/

using System;
using System.Collections.Generic;

namespace GenericList
{
    public class GenericList<T>
    {
        private const int defaultCapacity = 4;
        //fields
        private T[] array; 
        private int capacity = defaultCapacity;
        private int size;
        //properties
        public int Size
        {
            get { return this.size; }
        }
        //class constructor that takes the capacity of the array as parameter
        public GenericList(int capacity = defaultCapacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException();
            else
                array = new T[capacity];
        }
        //autogrow method
        public void Expand(T[] array)
        { 
            int doubleCapacity = 2 * capacity;
            T[] doubleSizeArray = new T[doubleCapacity];
            Array.Copy(array, doubleSizeArray, doubleCapacity);
            array = doubleSizeArray;
        }
        //add element method
        public void Add(T element)
        {
            if (size >= array.Length)
                Expand(array);
            this.array[size] = element;
            this.size++;
        }
        //indexer (access element by index?)
        public T this[int index]
        {
            get
            {
                if (index >= this.size || index < 0)
                    throw new IndexOutOfRangeException();
                else
                    return array[index];
            }
            set 
            {
                if (index >= this.size || index < 0)
                    throw new IndexOutOfRangeException();
                else
                    array[index] = value;
            }
        }
        //removes element by index
        public void RemoveAt(int index)
        {
            if (index >= this.size || index < 0)
                throw new IndexOutOfRangeException();
            else
            {
                this.size--;
                Array.Copy(this.array, index + 1, this.array, index, this.size - index);
            }
            this.array[this.size] = default(T); //default(T) = null if T is a reference type
        }                                       //default(T) = 0    if T is a value     type                    
        //inserts element at given position
        public void Insert(int index, T element)
        {
            if (index >= this.size || index < 0)
                throw new IndexOutOfRangeException();
            if (this.size == array.Length)
                Expand(array);
            if (index < this.size && index >= 0)
                Array.Copy(this.array, index, this.array, index + 1, this.size - index);
            this.array[index] = element;
            this.size++;
        }
        //clears the list
        public void Clear()
        {
            if (this.size > 0) //if the list is not empty
            {
                Array.Clear(array, 0, this.size);
                this.size = 0;
            }
        }
        //Find index by value
        public int Find(T[] array, T element)
        {
            Array.Sort(array);
            int index = Array.BinarySearch(array, element);
            return index;
        }
        //ToString override
        public override string ToString()
        {
            T[] arrForString = new T[size];
            Array.Copy(array, arrForString, size);
            return String.Join(", ", arrForString);
        }
    }
}
