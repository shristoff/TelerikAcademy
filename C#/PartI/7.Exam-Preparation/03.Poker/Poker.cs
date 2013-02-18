using System;

class Poker
{
    static void Main()
    {
        int[] Cards = new int[5];
        int i = 0, j = 0, pair = 0, straight = 0;
        while (i <= 4)
        {
            string Cardstr = Console.ReadLine();
            switch (Cardstr)
            {
                case "J": Cardstr = "11"; break;
                case "Q": Cardstr = "12"; break;
                case "K": Cardstr = "13"; break;
                case "A": Cardstr = "14"; break;
            }
            Cards[i] = int.Parse(Cardstr);
            i++;
        }
        Array.Sort<int>(Cards, 0, 5);
        for (i = 0; i < Cards.Length - 1; i++)
		{
		    if ((Cards[i] + 1 == Cards[i + 1] || (Cards[4] == 14 && Cards[0] == 2 && Cards[1] == 3 && Cards[2] == 4 && Cards[3] == 5)))
                straight++;
            if (straight == 4)
                Console.WriteLine("Straight");
            for (j = 1; j < Cards.Length; j++)
            {
                if (i != j && i < j && Cards[i] == Cards[j])
                    pair++;
            }
        }
        switch (pair)
        {
            case 1: Console.WriteLine("One Pair"); break;
            case 2: Console.WriteLine("Two Pairs"); break;
            case 3: Console.WriteLine("Three of a Kind"); break;
            case 4: Console.WriteLine("Full House"); break;
            case 6: Console.WriteLine("Four of a Kind"); break;
            case 10: Console.WriteLine("Impossible"); break;
            default: if (straight != 4)
                        Console.WriteLine("Nothing");break;
        }
    }
}