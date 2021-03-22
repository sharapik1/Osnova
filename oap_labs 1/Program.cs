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
    abstract class Uchashchiysya
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Klass { get; set; }
        public int[] Otsenki { get; set; }

    }
    class Schoolboy : Uchashchiysya
    {

    }
    class Student : Uchashchiysya
    {

    }
    class Aspirant : Uchashchiysya
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            var UchashchiysyaList = new List<Uchashchiysya>();


            using (TextFieldParser parser = new TextFieldParser(@"Data2.csv"))

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
                    var name = fields[0];
                    var age = (Convert.ToInt32(fields[1]));
                    var klass = (Convert.ToInt32(fields[2]));
                    int[] otsenki = fields[3].Split(',').Select(i => Convert.ToInt32(i)).ToArray();
                    UchashchiysyaList.Add(new Schoolboy { Name = name, Age = age, Klass = klass, Otsenki = otsenki  }) ;
                }
            }
        }
    }
}








