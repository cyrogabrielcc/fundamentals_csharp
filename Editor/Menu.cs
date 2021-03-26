using System;

namespace Editor
{
    public static class Menu
    {
       public static void Show()
       {
           Console.Clear();
           Console.BackgroundColor=ConsoleColor.Blue;
           Console.BackgroundColor=ConsoleColor.Black;

           DrawScreen();
       } 

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 38; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
            System.Console.WriteLine("Editor HTML");
        }
    }
}