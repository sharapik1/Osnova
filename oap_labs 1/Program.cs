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
   public class Book
    {
        public string NameAvtor { get; set; }
        public string Izdatelstvo { get; set; }
        public string NameBook { get; set; }
        public int Year { get; set; }
        public int Stranitsi { get; set; }
        public Book(string nameavtor, string izdatelstvo,string namebook, int year, int stranistsi) 
        {
            NameAvtor = nameavtor;
            Izdatelstvo = izdatelstvo;
            NameBook = namebook;
            Year = year;
            Stranitsi = stranistsi;
          
        }

    }
    public  class Program
    {
        static void Main(string[] args)
        {
            var book = new List<Book>();
            string Filter = "";
            string Filter1 = "";
            
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

                    var BookInfo = fields[0];
                    Regex RegexExpretion = new Regex(@"(.*?)\.\s*(.*?)\..*:\s*(.*?),\s*(\d+).*\.\s*(\d+)");
                    Match Matches = RegexExpretion.Match(BookInfo);
                    if (Matches.Success)
                    {
                        var NameAvtor = Matches.Groups[2].Value;
                        if (Filter == "")

                            Filter = NameAvtor;
                        var Izdatelstvo = Matches.Groups[3].Value;
                        var NameBook = Matches.Groups[1].Value;
                        var Year = (Convert.ToInt32 (Matches.Groups[4].Value));
                        var Stranitsi = (Convert.ToInt32 (Matches.Groups[5].Value));
                        book.Add( new Book(NameAvtor,Izdatelstvo,NameBook,Year,Stranitsi));
                       

                    }
                    if (Matches.Success)
                    {
                        var NameBook = Matches.Groups[1].Value;
                        if (Filter1 == "")
                            Filter1 = NameBook;
                        var Izdatelstvo = Matches.Groups[3].Value;
                        var NameAvtor = Matches.Groups[2].Value;
                        var Year = (Convert.ToInt32(Matches.Groups[4].Value));
                        var Stranitsi = (Convert.ToInt32(Matches.Groups[5].Value));
                        book.Add(new Book(NameAvtor, Izdatelstvo, NameBook, Year, Stranitsi));
                    }




                }
            }

            var CurrentBooks = book.Where(s => s.NameAvtor.Equals(Filter)).ToList();
            foreach (var CurrentBook in CurrentBooks)
            {
                
                    Console.WriteLine($"Книги:{CurrentBook.NameBook}");
           
            }

            var BooksYear = book.Where(b => b.Year>(1900)).ToList();
            foreach (var BooksYears in BooksYear)
            {
                Console.WriteLine($"Список книг изданных после 1900 года:{BooksYears.NameBook}");
            }
            var CurrentIzd = book.Where(a => a.Izdatelstvo.Equals(Filter1)).ToList();
            foreach (var CurrentIz in CurrentBooks)
            {
                Console.WriteLine($"Книги, выпущенные заданным издательством:{CurrentIz.NameBook}");
            }
            Console.ReadKey();
        }

    }
}









