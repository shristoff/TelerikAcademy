/* Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and
 stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions
 and to free any used resources in the finally block. */

using System;
using System.Net;

class DownloadFileCatchExceptions
{
    static void Main()
    {
        WebClient webClient = new WebClient();
        using (webClient)
        {
            try
            {
                webClient.DownloadFile("http://blogs.learnnowonline.com/Portals/153597/images/csharp.png",
                @"C:\S\GoogleDrive\TelerikAcademy\C#\csharp.png");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null. -or- The fileName parameter is null.");
            }
            catch (WebException)
            {
                Console.WriteLine("The URI formed by combining BaseAddress and address is invalid.-or-Filename is null or Empty.-or- The file does not exist. -or- An error occurred while downloading data. -or- No internet connection");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            finally
            {
                downloader.Dispose();
            }
        }
    }
}
/*ArgumentNullException	
    The address parameter is null.
-or-
    The fileName parameter is null.
WebException	
    The URI formed by combining BaseAddress and address is invalid.
-or-
    filename is null or Empty.
-or-
    The file does not exist.
-or-
    An error occurred while downloading data.
NotSupportedException	
    The method has been called simultaneously on multiple threads.*/