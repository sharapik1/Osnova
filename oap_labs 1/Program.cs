using System;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace oap_labs_1
{
    interface IAPI
    {
        bool Login(string name, string password);
        bool Logout();
    }
    // класс реализующий интерфейс
    class Mock : IAPI
    {
        public bool Login(string name, string password)
        {
            return true;
        }
        public bool Logout()
        {
            return true;
        }
    }
    class Authorization : IAPI
    {
        public bool Login(string name, string password)
        {
            Console.WriteLine("Введите логин:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            string UserPass = Console.ReadLine();
            if (UserName == "user" && UserPass == "123456")
            {
                Console.WriteLine("Данные введены верно");
            }
            else
            {
                Console.WriteLine("Данные введены не верно");
            }
            return true;
        }

        public bool Logout()
        {
            return true;
        }
    }
    class AuthorizationinFile : IAPI
    {
        public bool Login(string name, string password)
        {


            using (TextFieldParser parser = new TextFieldParser(@"Logs.csv"))
            {
                // свойство TextFieldType определяет тип полей: с разделителями или фиксированной ширины
                parser.TextFieldType = FieldType.Delimited;

                // можно указать произвольный разделитель
                parser.SetDelimiters(",");

                // считываем пока не дойдем до конца файла
                while (!parser.EndOfData)
                {
                    //метод ReadFields разбивает исходную строку на массив строк
                    string[] fields = parser.ReadFields();
                    var Logs = fields[0];
                    var Pass = fields[1];
                    foreach (string field in fields)
                    {
                        if (name == Logs && password == Pass)
                        {
                            Console.WriteLine("Данные верны");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Не верно введены данные");

                        }
                    }
                }
                return false;
            }
        }

        public bool Logout()
        {
            return true;
        }
     
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAPI myAPI = new Authorization();
            if (myAPI.Login("userqweiu","123456qwtpk"))
            {
                Console.WriteLine("Авторизация успешна");
            }
            else
            {
                Console.WriteLine("Авторизация не успешна");
            }
            myAPI.Logout();
            Console.ReadLine();
        }
    }

}

        








