using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs_1

{
    /*class Program2
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person { Name = "Timur", Age = 17 };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.Read();
        }
    }
    class Person
    {
        private int age;
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new Exception("Лицам до 18 регистрация запрещена");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
    */
     /*class Program3
    {
        static void Main(string[] args)
        {
            try
            {
                TestClass.Method1();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Catch в Main : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Main");
            }
            Console.WriteLine("Конец метода Main");
            Console.Read();
        }
        class TestClass
        { 

        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Catch в Method1 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Method1");
            }
            Console.WriteLine("Конец метода Method1");
        }
        static void Method2()
        {
            try
            {
                int x = 8;
                int y = x / 0;
            }
            finally
            {
                Console.WriteLine("Блок finally в Method2");
            }
            Console.WriteLine("Конец метода Method2");
        }
    }
}
    
    }
     */
    class Program
     { 
         static void ExceptionTest()
         {


                 int x = 5;
                 int y = x / 0;
                 Console.WriteLine($"Результат: {y}");
                 Console.WriteLine("Конец программы");
                 Console.Read();


         }
         static void ExceptionTest2()
         {
             try
             {
                 int x = 5;
                 int y = x / 0;
             }
             catch
             {
                 Console.WriteLine("Найдено исключение!");
             }
             finally
             {
                 Console.WriteLine("Блок finnaly");
             }
             Console.WriteLine("Конец программы");
             Console.Read();
         }
         static void ExceptionTest3()
         {
             try
             {
                 int x = 5;
                 int y = x / 0;
                 Console.WriteLine($"Результат: {y}");
             }
             catch
             {
                 Console.WriteLine("Возникло исключение!");
             }
         }
         static void ExceptionTest4()
         {
             try
             {
                 int x = 5;
                 int y = x / 0;
                 Console.WriteLine($"Результат: {y}");
             }
             finally
             {
                 Console.WriteLine("Блок finally");
             }
         }
         static void ExceptionTest5()
         {
             Console.WriteLine("Введите число");
             int x = Int32.Parse(Console.ReadLine());

             x *= x;
             Console.WriteLine("Квадрат числа: " + x);
             Console.Read();
         }
         static void ExceptionTest6()
         {
             Console.WriteLine("Введите число");
             int x;
             string input = Console.ReadLine();
             if (Int32.TryParse(input, out x))
             {
                 x *= x;
                 Console.WriteLine("Квадрат числа: " + x);
             }
             else
             {
                 Console.WriteLine("Некорректный ввод");
             }
             Console.Read();
         }
         static void ExceptionTest7()
         {
             try
             {
                 int x = 5;
                 int y = x / 0;
                 Console.WriteLine($"Результат: {y}");
             }
             catch (DivideByZeroException)
             {
                 Console.WriteLine("Возникло исключение DivideByZeroException");
             }
         }
         static void ExceptionTest8()

         {
             int x = 1;
             int y = 0;

             try
             {
                 int result = x / y;
             }
             catch (DivideByZeroException) when (y == 0 && x == 0)
             {
                 Console.WriteLine("y не должен быть равен 0");
             }
             catch (DivideByZeroException ex)
             {
                 Console.WriteLine(ex.Message);
             }
         }
         static void ExceptionTest9()


             {
                 try
                 {
                     int x = 5;
                     int y = x / 0;
                     Console.WriteLine($"Результат: {y}");
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine($"Исключение: {ex.Message}");
                     Console.WriteLine($"Метод: {ex.TargetSite}");
                     Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
                 }

                 Console.Read();
             }
         static void ExceptionTest10()
        {
            double? pi = 3.14;
            char? letter = 'a';

            int m2 = 10;
            int? m = m2;

            bool? flag = null;

            // An array of a nullable value type:
            int?[] arr = new int?[10];
        }

         static void Main(string[] args)
         {
             // ExceptionTest();
             // ExceptionTest2();
             // ExceptionTest3();
             // ExceptionTest4();
             // ExceptionTest5();
             // ExceptionTest6();
             // ExceptionTest7();
             // ExceptionTest8();
             // ExceptionTest9();
             //ExceptionTest10();
             Console.ReadKey();
         }


      }
    
    

}





