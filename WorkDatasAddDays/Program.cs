using System;

namespace WorkDatasAddDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(-1));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));
        }
    }
}
