using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class AppendListToSB
    {
        public static void AppendList<T>(List<T> list, StringBuilder sb)
        {
            foreach (T item in list)
            {
                sb.AppendFormat("{0}", item);
            }
        }
    }
}
