using System;

class MarketingFirm
{
    static void Main()
    {
        Console.WriteLine("Please enter in this order First name, Family name, age, gender (m/f), IDnumber and UniqueNumber (4 digits):\n");
        string FirstName = Console.ReadLine();
        string FamilyName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine()); //byte (0 to 255): unsigned 8-bit
        char gender = char.Parse(Console.ReadLine());
        ushort IDnumber = ushort.Parse(Console.ReadLine()); //ushort (0 to 65,535): unsigned 16-bit
        string UniqueNumber = ("2756" + ushort.Parse(Console.ReadLine())); //uint (0 to 4,294,967,295): unsigned 32-bit
        Console.WriteLine("\nName: {0} {1}\nAge: {2}\nGender: {3}\nID: {4}\nUnique: {5}", FirstName, FamilyName, age, gender, IDnumber, UniqueNumber);
    }
}