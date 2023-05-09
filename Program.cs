using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adds a background color to the text displayed
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                  ");
            Console.WriteLine("                  ");
            Console.WriteLine("                  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                  ");
            Console.WriteLine("                  ");
            Console.WriteLine("                  ");

            Console.ReadKey();
            //Clears the terminal
            Console.Clear();
            //Adds a magenta background color to the entire terminal
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ReadKey();

            


        }
    }
}