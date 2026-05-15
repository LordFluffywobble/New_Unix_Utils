using System;
using System.IO;
using System.Linq;


namespace newLs;


internal class NewTouch
{
    internal void Touch()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Press f: for a new file\nPress d: for a new directory");
        Console.ResetColor();
        ConsoleKeyInfo touchInput = Console.ReadKey(true);   
      
        if (touchInput.Key == ConsoleKey.F)
        {   
            Console.Write("\nType the name of the file you wish to create: ");
            Console.ResetColor();
            string ?tRead = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(tRead))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You didn't enter a name");
                Console.ResetColor();
                return;
            }

            if (!File.Exists(tRead))
            {
                File.Create(tRead);
                Console.WriteLine($"Created the file {tRead}");
            }
            else
            {
                Console.WriteLine($"A directory named {tRead} already exists");
            }
        }
        
        if (touchInput.Key == ConsoleKey.D)
        {
            
            Console.Write("\nType the name of the directory you wish to create: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string ?tRead = Console.ReadLine();
            Console.ResetColor();

            if (string.IsNullOrWhiteSpace(tRead)) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You didn't enter a name");
                Console.ResetColor();
                return;
            }    

            if (!Directory.Exists(tRead))
            {
                Directory.CreateDirectory(tRead);
                Console.Write("You created the ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{tRead} ");
                Console.ResetColor();
                Console.Write("directory\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{tRead} ");
                Console.ResetColor();
                Console.WriteLine("already exists");
            }
        }      
        
    }  
}





//Environment.GetCommandLineArgs().Skip(1).ToArray(); //[0] Points to the program.exe so we start at [1]. Use LinQ to skip the first position.
                                                                               //Used for giving flags when you start the program.