using System;

class _04Exam
{
    static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("../../04.txt"));
#endif // This section is compiled in Debug Mode only.
        //DateTime start = DateTime.Now;

        //DateTime end = DateTime.Now;
        //Console.WriteLine((end - start).TotalMilliseconds + " ms.");
    }
}