/*5.Define a class BitArray64 to hold 64 bit values inside an ulong value. 
 Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.*/

using System;
using System.Linq;

namespace BitArray
{
    public class BitArrayTest
    {
        static void Main()
        {
            BitArray64 bitArray = new BitArray64();

            bitArray[63] = 1;
            bitArray[62] = 1;

            int index = 0;
            foreach (int bit in bitArray)
            {
                Console.WriteLine("Bit {0,2}: {1}", index, bit);
                index++;
            }

            Console.WriteLine(bitArray);
        }
    }
}
