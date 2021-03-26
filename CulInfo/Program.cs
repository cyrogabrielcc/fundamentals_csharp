using System;
using System.Globalization;

namespace CulInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //deve ser invocado como objeto
            var pt = new CultureInfo("pt-BR");
            var utcDate = DateTime.UtcNow;
            var currentculture = CultureInfo.CurrentCulture;
            
            System.Console.WriteLine(utcDate);
            System.Console.WriteLine(utcDate.ToLocalTime());
            System.Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("D", currentculture));

            System.Console.WriteLine("--------------------------------");

            var tzAutralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific");
            System.Console.WriteLine(tzAutralia);

            /*
             // var timeSpan = new TimeSpan();
            // Console.WriteLine(timeSpan);

            // var timeSpanNanosegundos = new TimeSpan(1);
            // Console.WriteLine(timeSpanNanosegundos);

            // var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            // Console.WriteLine(timeSpanHoraMinutoSegundo);

            // var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            // var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            // Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));            
            */
        }
    }
}
