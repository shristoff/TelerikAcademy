/*5.Define a class BitArray64 to hold 64 bit values inside an ulong value. 
 Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;
        
        public ulong Number 
        { 
            get { return this.number; }
            private set { this.number = value; }
        }

        public BitArray64(ulong number = (ulong)0)
        {
            this.Number = number;
        }
        //indexer
        public int this[int index]
        {
            get
            {
                //check if the index is in the range
                if (index >= 0 && index < 64)
                {
                    //creating a mask - bit 1 moved with index positions in left, all other bits are 0
                    ulong mask = (ulong)1 << index;
                    //Check the bit at position index
                    if ((number & mask) == 0)
                        return 0;
                    else
                        return 1;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index was outside the bounds of the array.");
                }
            }

            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Index was out of range");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("Bit must be 0 or 1.");
                }
                //creating a mask - bit 1 moved with index positions in left, all other bits are 0
                ulong mask = (ulong)1 << index;
                //changing the bit at position index
                if (value == 1)
                {
                    number = number | mask;
                }
                else //if value = 0 we creat mask with 1 and only one 0 at poisition index
                {
                    number = number & (~mask);
                }
            }
        }

        public override string ToString()
        {
            return String.Join("", this);
        }
        //override method Equals()
        public override bool Equals(object obj)
        {
            bool equals = false;
            //operator "as" returns null if object can't be casted to type BitArray
            BitArray64 other = obj as BitArray64;
            if (other != null && this.number == other.number)
            {
                equals = true;
            }
            return equals;
        }
        //override operator ==
        public static bool operator ==(BitArray64 array1, BitArray64 array2)
        {
            return BitArray64.Equals(array1, array2);
        }
        //override operator !=
        public static bool operator !=(BitArray64 array1, BitArray64 array2)
        {
            return !(BitArray64.Equals(array1, array2));
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<int>).GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }
    }
}
