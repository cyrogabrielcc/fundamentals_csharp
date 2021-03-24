using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

    static void Menu()
    {
        System.Console.WriteLine("S = Seg");
        System.Console.WriteLine("0 = Sair");
        System.Console.WriteLine("M = Min");
        System.Console.WriteLine("Digite um número:");
        
        //pegando dados
        string data = Console.ReadLine().ToLower();

        //taking the last 
        char type = char.Parse(data.Substring(data.Length - 1,1)); 
        
        //taking the firsts 
        int time = int.Parse(data.Substring(0, data.Length -1)); 
         //Start(value);

         int multiplier = 1;

         if(type == 'm') multiplier = 60; 
         if(time == 0) System.Environment.Exit(0);

         Start(time * multiplier);



    }
        static void Start(int time)
        {
            
            int currentTime = 0;

            while(time != currentTime)
            {
                Console.Clear();
                currentTime++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            System.Console.WriteLine("finish");
            Thread.Sleep(1500);
        }
    }
}
