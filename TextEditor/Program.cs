using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            System.Console.WriteLine("How do you do?");
            System.Console.WriteLine("1 - Open file: ");
            System.Console.WriteLine("2 - Create a new file:");
            System.Console.WriteLine("0 - Exit");
        
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;    
                case 1: Open(); break;    
                case 2: Edit(); break;   
                default: Menu(); break; 
            }
        }

        static void Open()
        {

        }

        static void Edit()
        {
            System.Console.WriteLine("Write your text (ESC to exit):");
            System.Console.WriteLine();

            string text = "";

            //do while he will dont press esc
            do 
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }

            while(Console.ReadKey().Key != ConsoleKey.Escape);
            
            Console.WriteLine(text);
        }
    }
}
