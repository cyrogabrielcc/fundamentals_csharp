using System;
using System.Globalization;
namespace parteUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
              Console.WriteLine("Digite um numero: ");
            double numero_um = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            Console.WriteLine("Soma: +");
            Console.WriteLine("Divisão: /");
            Console.WriteLine("Subtração: -");
            Console.WriteLine("Resto: %");
            Console.WriteLine("Multiplicação: *");
            Console.WriteLine("Potencia: **");
            Console.WriteLine("Raiz: r");
            Console.WriteLine("Menu: M");
            Console.WriteLine("SAIR: e" );
            string op = Console.ReadLine();
            double numero_dois = double.Parse(Console.ReadLine());
            Console.WriteLine("Selecione a operação: ");

            switch (op)
            {               
                case "+": Soma(numero_um, numero_dois); break;
                case "-": Subtracao(numero_um, numero_dois); break;
                case "/": Divisao(numero_um, numero_dois); break;
                case "*": Multiplicacao(numero_um, numero_dois); break;
                case "**": Potencia(numero_um, numero_dois); break;
                case "r": raiz(numero_um, numero_dois); break;
                case "m": Menu(); break;
                case "e": System.Environment.Exit(0); break; //encerrar a aplicação
                default: Console.WriteLine("Sem resposta"); break;
            }
        }

        static void raiz(double valor, double valor2)
        {
            var value = Math.Sqrt(valor);
            var value2 = Math.Sqrt(valor2);
            Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(value2.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Soma(double valor,  double valor2)
        {
            var value = (valor + valor2);
            Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
        }

         static void Subtracao(double valor,  double valor2)
        {
            var value = (valor - valor2);
            Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
        }
         static void Divisao(double valor,  double valor2)
        {
            var value =  (valor / valor2);
            Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
        }

         static void Multiplicacao(double valor,  double valor2)
        {
            var value =  (valor * valor2);
            Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Potencia(double valor,  double valor2)
        {
            var value =  Math.Pow(valor, valor2);
            Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
