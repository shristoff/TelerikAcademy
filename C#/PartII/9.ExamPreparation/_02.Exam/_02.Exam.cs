using System;

class _02Exam
{
    static int FindMaxNumberOfJumps(int[] circle)
    {
        int jumps = 0, maxNumOfjumps = 0;
        int start = 0, j = 0, step;
        bool[] visited = new bool[circle.Length];
        bool allVisited = false;
        for (step = 1; step < circle.Length; step++)
        {
            for (start = 0; start < circle.Length; start++)
            {
                if (start + step < circle.Length)
                while (circle[start] < circle[start + step])
                {
                    if (!visited[start + step])
                        {
                            visited[start] = true;
                            visited[start + step] = true;
                            jumps++;
                        }
                    else
                        break;
                    start = start + step;
                    if (start >= circle.Length)
                        start = start - circle.Length;
                }
                if (jumps > 0)
                {
                    if (jumps > maxNumOfjumps)
                        maxNumOfjumps = jumps;
                    for (int i = 0; i < visited.Length; i++)
                    {
                        if (visited[i])
                            visited[i] = false;
                    }
                    jumps = 0;
                }
            }
        }
        return maxNumOfjumps;
    }
    
    static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("../../02.txt"));
#endif // This section is compiled in Debug Mode only.
        //DateTime start = DateTime.Now;
        string inputStr = Console.ReadLine();
        string[] inputStrArr = inputStr.Split(',');
        int[] circle = new int[inputStrArr.Length] ;
        for (int i = 0; i < circle.Length; i++)
        {
            circle[i] = int.Parse(inputStrArr[i].Trim());
        }
        Console.WriteLine(FindMaxNumberOfJumps(circle));
        //DateTime end = DateTime.Now;
        //Console.WriteLine((end - start).TotalMilliseconds + " ms.");
    }
}