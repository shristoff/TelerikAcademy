using System;

class _01Exam
{
    static ulong ConvertNumSysBase168ToDecimal(string durNum)
    {
        ulong num = 0;
        byte i = 0, countOfNums = 0;
        string durChar;
        int durCharToNum, nSysBase = 168;
        while (i < durNum.Length)
        {
            if (durNum.Length >= i + 2 && (byte)durNum[durNum.Length - 2 - i] > 96) //check if the beginning of the string is small letter
            {
                durChar = durNum.Substring(durNum.Length - 2 - i, 2);
                i++;
            }
            else
                durChar = durNum[durNum.Length - 1 - i].ToString();
            if (durChar.Length == 2)
                durCharToNum = ((byte)durChar[0] - 96) * 26 + (byte)durChar[1] - 65;
            else
                durCharToNum = (byte)durChar[0] - 65;
            num = num + (ulong)durCharToNum * (ulong)(Math.Pow((double)nSysBase, (double)countOfNums));
            i++;
            countOfNums++;
        }
        return num;
    }

    static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("../../01.txt"));
#endif // This section is compiled in Debug Mode only.
        //DateTime start = DateTime.Now;

        Console.WriteLine(ConvertNumSysBase168ToDecimal(Console.ReadLine()));

        //DateTime end = DateTime.Now;
        //Console.WriteLine((end - start).TotalMilliseconds + " ms.");
    }
}