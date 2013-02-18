using System;
using System.Text;
using System.Text.RegularExpressions;

class GenomeDecoder
{
    static void Main()
    {
        string nm = Console.ReadLine();
        string lineNumStr;
        string[] nmArr = nm.Split(' ');
        int n = int.Parse(nmArr[0]);
        int m = int.Parse(nmArr[1]);
        string encodedGenome = Console.ReadLine();
        string[] numsStrArr = encodedGenome.Split('A', 'C', 'G', 'T');
        char[] letters = new char[numsStrArr.Length - 1];
        int[] numsArr = new int[numsStrArr.Length - 1];
        int i, j, numOfLetters = 0, lines, lineLength, lineNumLength, charNum = 0;
        for (i = 0; i < numsStrArr.Length - 1; i++)
        {
            if (numsStrArr[i] == "")
                numsStrArr[i] = "1";
            numsArr[i] = int.Parse(numsStrArr[i]);
        }
        i = 0;
        Match letter = Regex.Match(encodedGenome, @"[AGTC]+?");
        while (letter.Success)
        {
            letters[i] = letter.Value.ToCharArray()[0];
            letter = letter.NextMatch();
            i++;
        }
        for (i = 0; i < numsArr.Length; i++)
		{
            numOfLetters = numOfLetters + numsArr[i];
		}
        lineLength = n + n / m;
        lines = (int)Math.Ceiling((decimal)numOfLetters / (decimal)n);
        lineNumLength = lines.ToString().Length;
        StringBuilder decodedGenome = new StringBuilder();
        for (i = 0; i < letters.Length; i++)
        {
            decodedGenome.Append(letters[i], numsArr[i]);
        }
        decodedGenome.ToString().ToCharArray();
        StringBuilder row = new StringBuilder();
        for (j = 1; j <= lines; j++)
        {
            lineNumStr = new string(' ', lineNumLength - j.ToString().Length);
            row.Append(lineNumStr);
            row.Append(j);
            row.Append(' ');
            for (i = 1; i <= n; i++, charNum++)
            {
                row.Append(decodedGenome[charNum]);
                if (charNum == numOfLetters - 1)
                    break;
                if (i % m == 0 && i < n)
                    row.Append(' ');
            }
            Console.WriteLine(row.ToString());
            row.Clear();
        }
    }
}