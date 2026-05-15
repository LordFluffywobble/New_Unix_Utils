namespace newLs;

internal class PWD
{
    internal void Pwd()
    {
        string path = ".";
        string fullPath = Path.GetFullPath(path);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine(fullPath);
        Console.ResetColor();

        
    }
}