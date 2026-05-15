using System.Drawing;

namespace newLs;

internal class LS
{
    
    internal void Ls()
    {
        string path = ".";
        DirectoryInfo di = new DirectoryInfo(path);
        DirectoryInfo[] diArr = di.GetDirectories();
        
        string[] files = Directory.GetFiles(path);

        if (!di.Exists)
        {
            Console.WriteLine("No such directory");
        }
        else
        {
         foreach (DirectoryInfo dri in diArr  )
            {
                // Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{dri.Name}/");
            }
            Console.ResetColor();
        
        foreach (string fi in files)
            {
                Console.WriteLine($"{fi}");
            }
        }
    }
}