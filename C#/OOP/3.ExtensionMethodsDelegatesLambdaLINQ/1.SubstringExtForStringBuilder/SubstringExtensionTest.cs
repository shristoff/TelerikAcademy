﻿using System;
using System.Text;

namespace SubstringExtForStringBuilder
{
    class SubstringExtensionTest
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("ABCDEF");
            Console.WriteLine(sb.Substring(2));
        }
    }
}
