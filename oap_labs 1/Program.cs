using System;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
namespace oap_labs_1
{
    class Book
    {
        public string NameAvtor { get; set; }
        public string Familia { get; set; }
        public string Otchestvo { get; set; }
        public string Izdatelstvo { get; set; }
        public string NameBook { get; set; }
        public int Year { get; set; }
        public int Stranitsi { get; set; }
        public Book(string nameavtor, string familia, string otchestvo, string izdatelstvo,string namebook, int year, int stranistsi) 
        {
            NameAvtor = nameavtor;
            Familia = familia;
            Otchestvo = otchestvo;
            Izdatelstvo = izdatelstvo;
            NameBook = namebook;
            Year = year;
            Stranitsi = stranistsi;
        }

    }
    class Program
    {
        public void Main(string[] args)
        {
            var book = new List<Book>();
            

            
            using(TextFieldParser parser = new TextFieldParser(@"Data.csv"))
                
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

                    var BookInfo = fields[0]

                    Book Frang = new Book();
                    {

                    }
                    
                        
                    
                }
            }
        }
    }
}









