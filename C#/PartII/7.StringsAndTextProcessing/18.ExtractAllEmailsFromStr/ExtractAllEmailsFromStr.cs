/* Write a program for extracting all email addresses from given text. All substrings that match the format 
<identifier>@<host>…<domain> should be recognized as emails. */

using System;
using System.Text.RegularExpressions;

class ExtractAllEmailsFromStr
{
    static void Main()
    {
        string textWithEMails = "Stefany's email is stefanie@inet.com, mine is stefan@jobs.net and Johns's is Jon@gov.eu";
        string emailPattern = @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b";
        Match emailMatch = Regex.Match(textWithEMails, emailPattern, RegexOptions.IgnoreCase);
        Console.WriteLine("The text is:\n\n{0}\n", textWithEMails);
        Console.WriteLine("The e-mails in the text are:\n");
        while (emailMatch.Success)
        {
            Console.WriteLine(emailMatch.Value);
            emailMatch = emailMatch.NextMatch();
        }
        Console.WriteLine();
    }
}