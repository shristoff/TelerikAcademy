using System;
using System.Text.RegularExpressions;

class _03Exam
{
    static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("../../03.txt"));
#endif // This section is compiled in Debug Mode only.
        //DateTime start = DateTime.Now;
        int i = 0;
        int numOfLines = int.Parse(Console.ReadLine());
        string tab = Console.ReadLine();
        string[] input = new string[numOfLines];
        string[] output = new string[numOfLines];
        while (i < numOfLines)
        {
            input[i] = Console.ReadLine();
            //output[i] = input[i].Replace("{", "\n{\n");
            i++;
        }
        string pattern = @".?({).?";
        Match openBracket = Regex.Match(input[0], pattern);
        string output1 = Regex.Replace(input[0], openBracket.Groups[1].Value, "\n{\n");
        Console.WriteLine(output1);
        
        

        //DateTime end = DateTime.Now;
        //Console.WriteLine((end - start).TotalMilliseconds + " ms.");
    }
}