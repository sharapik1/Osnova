using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // объявление массива
            var Massiv = new int[10];
            var maxValue = -1;
            // генератор случайных чисел
            Random Rand = new Random();

            // заполняем массив случайными числами 0..100
            for (int i = 0; i < Massiv.Length; i++)
            {
                Massiv[i] = Rand.Next(100);
                if (Massiv[i] > maxValue)
                    maxValue = Massiv[i];
                Console.Write($"{Massiv[i]}\t");
             }
            Console.Write($"\n Maximum = {maxValue}");
            Console.ReadLine();
            */
            /*
            var Massiv = new int[5];

            Random Rand = new Random();
            var Summa = 0;
            var Proizvidenie = 1L;
            for (int i = 0; i < Massiv.Length; i++)
            {
                Massiv[i] = Rand.Next(100);
                Summa += Massiv[i];
                Proizvidenie = Proizvidenie * Massiv[i];
                Console.Write($"{Massiv[i]}\t");
            }
            Console.Write($"\nsumma = {Summa}\nпроизведение = {Proizvidenie}");
            Console.ReadLine();
            */
            /*
            Console.Write("Input Min: ");
            var MinValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Max: ");
            var MaxValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Shag: ");
            var Shag = Convert.ToInt32(Console.ReadLine());

            for (int i = MinValue; i <= MaxValue; i += Shag)
            {

                Console.Write($"{i}\t");

                Console.ReadLine();

            }
            */
            /*
            int factrorial;
            long f1;

            long i;          
            Console.Write("Введите factorial:");
            var factorial = Convert.ToInt32(Console.ReadLine());
            
            f1 = 1;
            for (i = 1; i <= factorial; i++)
            {
                f1 *= i;
            }
            Console.WriteLine("{0}!={1}", factorial, f1);       
            Console.ReadLine();
            */
        } 
    }
}







