using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace oap_labs_1
{
    class Program

    {
        static void Exercise()
        {
            Console.WriteLine("Введите строку для поиска времени: ");
            var time = Console.ReadLine();
            Regex RegexExpretion = new Regex(@"([0][1-9]|[1][0-9]|[2][0-3]):([0-5][0-9])");
            var Result = RegexExpretion.Match(time);

            if (RegexExpretion.IsMatch(time))
            {
                Console.WriteLine(Result.Value);
            }
            else
            {
                Console.WriteLine("неккоректное время");
            }
        }
        static void Exercise2()
        {
            
            
                Console.WriteLine("Введите строку для поиска html цвета: ");
                var html = Console.ReadLine();
                Regex RegexExpretion = new Regex(@"#([0-9]|[A-F]){6}");
                var Result = RegexExpretion.Match(html);

                if (RegexExpretion.IsMatch(html))
                {
                    Console.WriteLine(Result.Value);
                }
                else
                {
                    Console.WriteLine("неккоректный цвет");
                }
                Console.ReadKey();
            
        }
        static void Exercise3()
        {
            Console.WriteLine("Введите строку для поиска арифметических операций: ");
            var InpString = Console.ReadLine();
            Regex RegexExpretion = new Regex(@"([-+]?(?:\d+(?:\.\d*)?|\.\d+)(?:[eE][-+]?\d+)?)([+]|[-]|[][\/]?)([-+]?(?:\d+(?:\.\d)?|\.\d+)(?:[eE][-+]?\d+)?)");
            var Result = RegexExpretion.Match(InpString);

            if (RegexExpretion.IsMatch(InpString))
            {
                Console.WriteLine(Result.Value);
            }
            else
            {
                Console.WriteLine("неккоректная строка");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
             //Exercise();
            // Exercise2();
           Exercise3();
            Console.ReadKey();

        }
    }
}
        














