using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using System.Runtime.Serialization.Json;

namespace oap_labs_1
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Group { get; set; }
        public Student() { }
    }
    class Program
    {
        static void Import()
        {
            var StudentList = new List<Student>();
            using (TextFieldParser parser = new TextFieldParser(new StringReader("Иванов Иван Иванович,01.01.2000,И-21\nПетров Петр Петрович,02.02.2002,С-21\nСидоров Сидор Сидорович,03.03.2003,И-31")))
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
                    var Student1 = new Student();
                    Student1.Name = fields[0];

                    var DateParts = fields[1].Split('.');

                    Student1.BirthDay = new DateTime(Convert.ToInt32(DateParts[2]), Convert.ToInt32(DateParts[1]), Convert.ToInt32(DateParts[0]));

                    Student1.Group = fields[2];
                    StudentList.Add(Student1);

                }
                XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
                using (FileStream fs = new FileStream("Students.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, StudentList.ToArray());

                }
            }
        }

        static void Export()

        {
            using (FileStream fs = new FileStream("Students.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
                Student[] newpeople = (Student[])formatter.Deserialize(fs);

                var ms = new MemoryStream();
                var Serializer = new DataContractJsonSerializer(typeof(Student[]));


                Serializer.WriteObject(ms, newpeople);
                ms.Position = 0;
                StreamReader reader = new StreamReader(ms);
                string text = reader.ReadToEnd();
                Console.WriteLine(text);
                ///Student restoredStudent = JsonSerializer.Deserialize<Student>(json);
            }
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            //Import();

            Export();

            

            }
        }
    }









