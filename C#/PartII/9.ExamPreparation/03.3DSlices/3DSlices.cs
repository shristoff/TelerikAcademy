using System;

class Program
{
    static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("../../input.txt"));
#endif // This section is compiled in Debug Mode only.
        //DateTime start = DateTime.Now;

        //DateTime end = DateTime.Now;
        //Console.WriteLine((end - start).TotalMilliseconds + " ms.");
    }
}