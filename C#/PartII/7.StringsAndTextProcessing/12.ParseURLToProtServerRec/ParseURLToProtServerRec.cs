/* Write a program that parses an URL address given in the format:
 and extracts from it the [protocol], [server] and [resource] elements. For example from the URL 
 http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php" */

using System;
using System.Text.RegularExpressions;

class ParseURLToProtServerRec
{
    static void Main()
    {
        string urlAddress = "http://telerikacademy.com/Courses/Courses/Details/20";
        string protocol = "[^:]*";
        string server = @"/([^/][\w\.]*)";
        string resource = @"\b/[^/][\w.]*.+";
        Match matchProt = Regex.Match(urlAddress, protocol);
        Match matchServer = Regex.Match(urlAddress, server);
        Match matchResource = Regex.Match(urlAddress, resource);
        Console.WriteLine("[protocol] = \"{0}\"", matchProt);
        Console.WriteLine("[server] = \"{0}\"", matchServer.Groups[1]);
        Console.WriteLine("[server] = \"{0}\"", matchResource);
    }
}