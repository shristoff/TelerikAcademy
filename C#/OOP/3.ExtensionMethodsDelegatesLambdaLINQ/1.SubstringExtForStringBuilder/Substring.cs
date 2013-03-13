/* 1.Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new 
 StringBuilder and has the same functionality as Substring in the class String.*/

using System;
using System.Text;

namespace SubstringExtForStringBuilder
{
    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder inputStr, int startIndex, int length = 0)
        {
            if (startIndex < 0 || length < 0 || startIndex + length >= inputStr.Length)
                throw new ArgumentOutOfRangeException();
            if (length == 0)
                length = inputStr.Length - startIndex;
            char[] substringCharArr = new char[length];
            inputStr.CopyTo(startIndex, substringCharArr, 0, length);
            string temp = new string(substringCharArr);
            StringBuilder substring = new StringBuilder(temp);
            return substring;
        }
    }
}
