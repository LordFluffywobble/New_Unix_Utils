namespace newLs;

internal class RM
{
    internal void Rm()
    {
        Console.WriteLine("Enter the name of the file or directory you wish to delete");
        string ?rRead = Console.ReadLine();

        
        if (String.IsNullOrWhiteSpace(rRead))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You didn't enter the name of a file or directory");
            Console.ResetColor();
        }
        if (File.Exists(rRead))
        {
            File.Delete(rRead);
            Console.Write("Deleted the file: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{rRead}");
            Console.ResetColor();
            return;
        }           
        if (Directory.Exists(rRead))
        {
            Directory.Delete(rRead, true);
            Console.Write("Deleted the directory: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{rRead}");
            Console.ResetColor();
            return;
        }
        Console.Write("There is no file or directory called ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{rRead}");
        Console.ResetColor();
    }
}
    