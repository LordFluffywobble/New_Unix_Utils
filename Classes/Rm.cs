namespace newLs;

internal class RM
{
    internal void Rm()
    {
        Console.WriteLine("Enter the name of the directory you wish to delete");
        string ?rRead = Console.ReadLine();

        
        if (String.IsNullOrWhiteSpace(rRead))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You didn't enter the name of a direcotry or a file");
            Console.ResetColor();
        }
        else if (!Directory.Exists(rRead))
        {
            if (!File.Exists(rRead))
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{rRead} does not exist");
            Console.ResetColor();
        }
        else
        {
            if (File.Exists(rRead))
            {
                File.Delete(rRead);
                Console.Write("Deleted the file: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{rRead}");
                Console.ResetColor();
                return;
            }
            Directory.Delete(rRead, true);
            Console.Write("Deleted the directory: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{rRead}");
            Console.ResetColor();
        }
    }
}
    