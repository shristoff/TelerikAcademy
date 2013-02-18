using System;
using System.Text;

class ReadPrintCompanyData 
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Please enter company name: ");
        string CoName = Console.ReadLine();
        Console.Write("Please enter company address: ");
        string CoAddress = Console.ReadLine();
        Console.Write("Please enter company phone number: ");
        string CoPhone = Console.ReadLine();
        Console.Write("Please enter company fax number: ");
        string CoFax = Console.ReadLine();
        Console.Write("Please enter company web site: ");
        string CoSite = Console.ReadLine();
        Console.Write("Please enter manager first name: ");
        string ManFName = Console.ReadLine();
        Console.Write("Please enter manager last name: ");
        string ManLName = Console.ReadLine();
        Console.Write("Please enter manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Please enter manager phone number: ");
        string ManPhone = Console.ReadLine();
        Console.WriteLine("1. Company name:".PadRight(20, ' ') + "{0,20}", CoName);
        Console.WriteLine("2. Company address:".PadRight(20, ' ') + "{0,20}", CoAddress);
        Console.WriteLine("3. Company phone:".PadRight(20, ' ') + "{0,20}", CoPhone);
        Console.WriteLine("4. Company fax:".PadRight(20, ' ') + "{0,20}", CoFax);
        Console.WriteLine("5. Company site:".PadRight(20, ' ') + "{0,20}", CoSite);
        Console.WriteLine("6. Manager name:".PadRight(20, ' ') + "{0,20}", ManFName + " " + ManLName);
        Console.WriteLine("7. Manager age:".PadRight(20, ' ') + "{0,20}", age);
        Console.WriteLine("8. Manager phone:".PadRight(20, ' ') + "{0,20}", ManPhone);
    }
}
