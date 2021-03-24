using System;
using System.IO;

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
            Console.Clear();
            System.Console.WriteLine("What the path? ");
            var path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
               string text = file.ReadToEnd();  
               System.Console.WriteLine(text);
            }
            System.Console.WriteLine("");
            Console.ReadLine();
            Menu();
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
            
            Save(text);
        }
    
        static void Save(string text)
        {
            Console.Clear();
            System.Console.WriteLine("where u can save this?");
            var path = Console.ReadLine();
            
            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            System.Console.WriteLine($"Sucess to save in {path}");
        }   
    }
}

//C:\Users\cyrog\Desktop\CSharpFundamentals\TextEditor
