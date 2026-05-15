using System.IO;

namespace newLs;

internal class CAT
{
    internal void Cat()
    {
        Console.WriteLine("Enter the name of the file you wish to read");
        string ?cRead = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(cRead))
        {
            Console.WriteLine("You didn't enter the name of a file");
        }
        else if (!File.Exists(cRead))
        {
            Console.Write($"There is no file called ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{cRead}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach(string a in File.ReadLines(cRead))
            Console.WriteLine(a);
        }
        Console.ResetColor();
    }
}