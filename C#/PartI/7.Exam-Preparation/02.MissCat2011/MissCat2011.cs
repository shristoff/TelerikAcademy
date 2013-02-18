/*There are always ten cats that participate in the final round of the contest, numbered 1 to 10. 
The jury of the contest consists of N people who subjectively decide which cat to vote for. 
In other words each person votes for just 1 cat that he has most liked, 
or from whose owner he has received the biggest bribe.
The winner of the contest is the cat that has gathered most votes. 
If two cats have equal votes, the winner of the contest is the one whose number is smaller.
Your task is to write a computer program that finds the number of the cat that is going to win the contest “Miss cat” */

using System;

class MissCat2011
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        int[] numOfVotes = new int[11]; 
        int winnerVotes = 0;
        int iMaxPosition = 0;
        int i = 0;
        while (i < N)
        {
            string JuryMemberVotestr = Console.ReadLine();
            byte JuryMemberVote = byte.Parse(JuryMemberVotestr);
            numOfVotes[JuryMemberVote]++;
            i++;
        }
        for (i = 1; i <= 10; i++)
        {
            if (winnerVotes < numOfVotes[i])
            {
                winnerVotes = numOfVotes[i];
                iMaxPosition = i;
            }
        }
        Console.WriteLine(iMaxPosition);
    }
}
