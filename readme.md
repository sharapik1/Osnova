<table style="width: 100%;">
  <tr>
    <td style="text-align: center; border: none;"> 
    Минестерство образования и науки РФ <br>
    ГБПОУ РМЭ "Йошкар-Олинский Технологический колледж </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;"><h2>Отчет по лабораторной работe<h2><br>
    По теме: Основные принципы объектно-ориентированного программирования 
    </td>
  </tr>
  <tr>
    <td style="text-align: right; border: none; height: 20em;">
      Разработали: Игимбаев Тимур и Шарапова Екатерина<br/>
      Группа: И-21<br/>
      Проверил: Колесников Е.И.       
    </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 5em;">
    г.Йошкар-Ола, 2021</td>
  </tr>
</table>

<div style="page-break-after: always;"></div>

# Цели и задачи:
1. Ознакомиться с информацией из [лекции](https://github.com/kolei/OAP/blob/master/articles/t6_oop1.md) 
2. Используя информацию из лекции разработать классы для объекта: <br>Book: Автор, Название, Издательство, Год, Количество страниц. И загрузить данные из CSV файла <br> Также вывести: <br>список книг заданного автора <br> список книг, выпущенных заданным издательством <br> список книг, выпущенных после заданного года

# Краткий теоретический материал:
C# является полноценным объектно-ориентированным языком. Это значит, что программу на C# можно представить в виде взаимосвязанных взаимодействующих между собой объектов.

Описанием объекта является класс, а объект представляет экземпляр этого класса. Можно еще провести следующую аналогию. У нас у всех есть некоторое представление о человеке, у которого есть имя, возраст, какие-то другие характеристики. То есть некоторый шаблон - этот шаблон можно назвать классом. Конкретное воплощение этого шаблона может отличаться, например, одни люди имеют одно имя, другие - другое имя. И реально существующий человек (фактически экземпляр данного класса) будет представлять объект этого класса.

По умолчанию проект консольного приложения уже содержит один класс Program, с которого и начинается выполнение программы.

1. Классы и объекты
2. Конструкторы
3. Создание конструкторов
4. Структуры
5. Свойства
# Вывод: 
1. Мы разработали класс Book:
```
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
```
2. Создали CSV файл:
```
using(TextFieldParser parser = new TextFieldParser(@"Data.csv"))
```
3. Далее в этом файле мы вывели: 
``` 
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
```
