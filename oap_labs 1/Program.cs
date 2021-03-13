using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs
{
    
    class Program
    {
       { /*
        static void Factorial()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"Факториал равен {result}");
        }
        // определение асинхронного метода
        static async void FactorialAsync()
        {
            Console.WriteLine("Введите число: ");
            var chislo = Convert.ToDouble(Console.ReadLine());
            var Factorial1 = 1;
            for (int i = 2; i <= chislo; i++)
            {
                Factorial1 = Factorial1 * i;
                Console.Write($"{Factorial1}\t");
            }
            Console.Write($"\nФакториар равен = {Factorial1}\t");
        }
        static void Main(string[] args)
        {
            FactorialAsync();   // вызов асинхронного метода
            Console.WriteLine("\nВведите число: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа равен {n * n}");
            Console.Read();
        */
        /*
        static async void ReadWriteAsync()
        {
            string s = "Hello world! One step at a time";
            // hello.txt - файл, который будет записываться и считываться
            using (StreamWriter writer = new StreamWriter("hello.txt", false))
            {
                await writer.WriteLineAsync(s);  // асинхронная запись в файл
            }
            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {
            ReadWriteAsync();
            Console.WriteLine("Некоторая работа");
            Console.Read();
        */
        /*
        static async void ReadWriteAsync()
        {
            string s = "Hello world! One step at a time";
            // hello.txt - файл, который будет записываться и считываться            
            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {
            ReadWriteAsync();
            Console.WriteLine("Некоторая работа");
            Console.Read();
        */
        /*
        static void Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал равен {result}");
        }
        // определение асинхронного метода
        static async Task FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
        static void Main(string[] args)
        {
            FactorialAsync(5);
            FactorialAsync(6);
            FactorialAsync(7);
            Console.Read();
        

        }
    }
}









