namespace newLs;

internal class ECHO
{
    internal void Echo()
    {
        Console.WriteLine("Echo Messaeg");
        string ?eRead = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(eRead))
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("You didn't enter anything.\nReturning");
            Console.ResetColor();
            return;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(eRead);
            Console.ResetColor();
        }
    }
}