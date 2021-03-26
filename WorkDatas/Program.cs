using System;

namespace WorkDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var data = DateTime.Now; //data do momento
            //                      AAAA/MM/DD - HH/MM/SS
            var data2 = new DateTime(2020, 10,12,8,23,5); //data do momento

            System.Console.WriteLine(data);
            System.Console.WriteLine(data);
            System.Console.WriteLine(data.DayOfWeek);
            System.Console.WriteLine((int)data.DayOfWeek + " convertido pra string -> dia da semana");
            System.Console.WriteLine(data.Date);
            System.Console.WriteLine(data.Month);
            System.Console.WriteLine(data2);
        }
    }
}
