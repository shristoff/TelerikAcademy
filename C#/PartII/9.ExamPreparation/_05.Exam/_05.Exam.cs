using System;

class _05Exam
{
    static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("../../05.txt"));
#endif // This section is compiled in Debug Mode only.
        //DateTime start = DateTime.Now;

        //DateTime end = DateTime.Now;
        //Console.WriteLine((end - start).TotalMilliseconds + " ms.");
    }
}