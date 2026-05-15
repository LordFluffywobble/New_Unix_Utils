
using System.Runtime.CompilerServices;

namespace newLs;

internal class Commands
{
    internal void GetCommand()
    {
        bool running = true;
        LS ls = new();
        NewTouch touch = new();
        ECHO echo = new();
        PWD pwd = new();
        RM rm = new();
        CAT cat = new();
        
        
      
        while (running)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMain Menu");
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Press h for a help menu");
            Console.ResetColor();
            ConsoleKeyInfo input = Console.ReadKey(true);
           
            Console.WriteLine();
            running = input.Key switch
            {
                ConsoleKey.Escape or ConsoleKey.Q  =>  false,
                ConsoleKey.D        => Voidhelper(()    => ls.Ls()),
                ConsoleKey.T        => Voidhelper(()    => touch.Touch()),
                ConsoleKey.H        => Voidhelper(()    => Help()),
                ConsoleKey.E        => Voidhelper(()    => echo.Echo()),
                ConsoleKey.P        => Voidhelper(()    => pwd.Pwd()),
                ConsoleKey.R        => Voidhelper(()    => rm.Rm()),
                ConsoleKey.C        => Voidhelper(()    => cat.Cat()),
                                   _=> true 
                
            };
            
            bool Voidhelper(Action action)
            {
                action();
                return true;
            }
            
        } 
    }
    internal void Help()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Press d to print the contents of the current directory\nPress t to create a new file or folder");
        Console.WriteLine("Press e to echo your message");
        Console.WriteLine("Press p to print the full current path");
        Console.WriteLine("Press r to remove a directory or file");
        Console.WriteLine("Press c + filename to print out the contents of the file");
        Console.WriteLine("Press q or escape to exit");
    }
}