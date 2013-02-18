/* Write a program that encodes and decodes a string using given encryption key (cipher). 
The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
operation over the first letter of the string with the first of the key, the second – with the second, etc. 
When the last key character is reached, the next is the first.*/

using System;

class EncodeDecodeStrWithKey
{
    static void Main()
    {
        string toEncode = "This is some random string";
        char[] toEncodeArr = toEncode.ToCharArray();
        string key = "Yoda";
        for (int s = 0, k = 0; s < toEncode.Length; k++, s++)
        {
            toEncodeArr[s] = (char)(toEncode[s] ^ key[k]);
            if (k == key.Length - 1)
                k = 0;
            Console.Write(toEncodeArr[s]);
        }
        Console.WriteLine();
        string toDecode = new string(toEncodeArr);
        for (int s = 0, k = 0; s < toDecode.Length; k++, s++)
        {
            toEncodeArr[s] = (char)(toEncodeArr[s] ^ key[k]);
            if (k == key.Length - 1)
                k = 0;
            Console.Write(toEncodeArr[s]);
        }
        Console.WriteLine();
    }
}