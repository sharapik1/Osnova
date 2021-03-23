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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace oap_labs_1
{
    [Serializable]
    [DataContract]
    abstract  public class Uchashchiysya
    {
        abstract public bool AllowMoney();
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
    }
    [Serializable]
    [DataContract]
    public class UchashchiysyaWithOcenca : Uchashchiysya
    {
        [DataMember]
        public int[] Otsenki { get; set; }

        public override bool AllowMoney()
        {
            return Otsenki.Average() >= 4;
        }
    }

    class Schoolboy : UchashchiysyaWithOcenca
    {
        public string Klass { get; set; }
    }
    [DataContract]
    class Student : UchashchiysyaWithOcenca
    {
        [DataMember]
       public string Group { get; set; }

    }
    [Serializable]
     public class Aspirant : Uchashchiysya
    {

        public string Obrazovanie { get; set; }
        public string Rucovoditel { get; set; }
        public string[] Publicapublikatsii { get; set; }

        public override bool AllowMoney()
        {
            return Publicapublikatsii.Length > 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var SchoolboyList = new List<Schoolboy>();


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
                    var klass = fields[2];
                    int[] otsenki = fields[3].Split(',').Select(i => Convert.ToInt32(i)).ToArray();
                    SchoolboyList.Add(new Schoolboy { Name = name, Age = age, Klass = klass, Otsenki = otsenki  }) ;
                }
            }
            Student[] StudentArray;
            var Serializer = new DataContractJsonSerializer(typeof(Student[]));
            using (var sr = new StreamReader("data3.JSON"))
            {
                StudentArray = (Student[])Serializer.ReadObject(sr.BaseStream);
            }
            
            Aspirant[] aspirantArray;
            
            XmlSerializer formatter = new XmlSerializer(typeof(Aspirant[]));
            using (FileStream fs = new FileStream("Data4.XML", FileMode.OpenOrCreate))
            {
                aspirantArray = (Aspirant[])formatter.Deserialize(fs);
                
            }

            var res = SchoolboyList.Concat<Uchashchiysya>(StudentArray).Concat(aspirantArray).Where(u => u.AllowMoney());
            foreach (var people in res)
                Console.WriteLine($"{people.Name}") ;
            Console.ReadKey();
        }

    }
}








