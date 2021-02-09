using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace oap_labs_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //команда Console.Write выводит текст в консоль
            Console.Write("Input katet1: ");
            // команда Console.ReadLine читает СТРОКУ из консоли
            var Katet1 = Console.ReadLine();

            Console.Write("Input katet2: ");
            var Katet2 = Console.ReadLine();

            // команда Math.Sqrt - квадратный корень
            // Math.Pow - возведение в степень
            // Convert.ToDouble - преобразует строку в число
            var Gipotenuza = Math.Sqrt(Math.Pow(Convert.ToDouble(Katet1), 2) + Math.Pow(Convert.ToDouble(Katet2), 2));
            var Perimetr = Convert.ToDouble(Katet1) + Convert.ToDouble(Katet2) + Convert.ToDouble(Gipotenuza);
            var Ploshad = (Convert.ToDouble(Katet1) * Convert.ToDouble(Katet2)) / 2;

            // выводим результат
            // знак $ перед строкой указывает, что внутри строки в фигурных скобках названия переменных
            Console.WriteLine($"Perimetr = {Perimetr}");
            Console.WriteLine($"Ploshad = {Ploshad}");
            // читаем строку, чтобы консольное окно сразу не закрылось
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}
        */




// подключены какие-то библиотеки


// namespace такой же как и название проекта
/*
namespace oap_labs
{
    // про классы мы пока не говорили...
    class Program
    {
        // точка входа в программу
        static void Main(string[] args)
        {
            // команда Console.Write выводит текст в консоль
            Console.Write("input Хa ");
            // команда Console.ReadLine читает СТРОКУ из консоли
            var Xa = Console.ReadLine();
            Console.Write("input Xb");
            var Xb = Console.ReadLine();
            Console.Write("Input Ya ");
            var Ya = Console.ReadLine();
            Console.Write("input Yb");
            var Yb = Console.ReadLine();           
            Console.Write("input Xc");
            var Xc = Console.ReadLine();
            Console.Write("input Yc");
            var Yc = Console.ReadLine();
            var AB = Math.Sqrt(
             Math.Pow(Convert.ToDouble(Xb) - Convert.ToDouble(Xa), 2) +
             Math.Pow(Convert.ToDouble(Yb) - Convert.ToDouble(Ya), 2)
             );
            var BC = Math.Sqrt(
            Math.Pow(Convert.ToDouble(Xc) - Convert.ToDouble(Xb), 2) +
            Math.Pow(Convert.ToDouble(Yc) - Convert.ToDouble(Yb), 2)
            );
            var AC = Math.Sqrt(
            Math.Pow(Convert.ToDouble(Xc) - Convert.ToDouble(Xa), 2) +
            Math.Pow(Convert.ToDouble(Yc) - Convert.ToDouble(Ya), 2)
            );
            // команда Math.Sqrt - квадратный корень
            // Math.Pow - возведение в степень
            // Convert.ToDouble - преобразует строку в число
            var Perimetr = (Convert.ToDouble(AB)) + (Convert.ToDouble(BC)) + (Convert.ToDouble(AC));
            var PolyPerimetr = Convert.ToDouble(Perimetr) / 2;
            var Ploshad = Math.Sqrt(
            Convert.ToDouble(PolyPerimetr) * (Convert.ToDouble(PolyPerimetr) - Convert.ToDouble(AB)) *
            (Convert.ToDouble(PolyPerimetr) - Convert.ToDouble(BC)) *
            (Convert.ToDouble(PolyPerimetr) - Convert.ToDouble(AC))
            );
            // выводим результат
            // знак $ перед строкой указывает, что внутри строки в фигурных скобках названия переменных
            Console.WriteLine($"Perimetr = {Perimetr}");
            Console.WriteLine($"Ploshad = {Ploshad}");

            // читаем строку, чтобы консольное окно сразу не закрылось
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}
*/

/*
Console.Write("Inpat radius: ");
var radius = Console.ReadLine();
var dlina = Convert.ToDouble(radius) * Math.PI * 2;
var ploshad = Math.Pow(Convert.ToDouble(radius), 2) * Math.PI;
Console.WriteLine($"dlina = {dlina}");
Console.WriteLine($"Ploshad = {ploshad}");
Console.Write("Press ENTER to continue...");
Console.ReadLine();
*/






