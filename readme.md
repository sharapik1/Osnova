<table style="width: 100%;">
  <tr>
    <td style="text-align: center; border: none;"> 
    Минестерство образования и науки РФ <br>
    ГБПОУ РМЭ "Йошкар-Олинский Технологический колледж </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;"><h2>Отчет по лабораторной работe<h2><br>
    По теме: Регулярные Выражания 
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
1. Ознакомиться с Регулярными Выражениями 
2. Попрактиваоться с Регулярными Выражениями

# Краткий теоретический материал:
Регулярное выражение — это строка, задающая шаблон поиска подстрок в тексте. Одному шаблону может соответствовать много разных строчек.

Термин «Регулярные выражения» является переводом английского словосочетания «Regular expressions». Перевод не очень точно отражает смысл, правильнее было бы «шаблонные выражения».

Регулярное выражение, или коротко «регулярка», состоит из обычных символов и специальных командных последовательностей.

Например, \d задаёт любую цифру, а \d+ — задает любую последовательность из одной или более цифр.

Работа с регулярками реализована во всех современных языках программирования.

Однако существует несколько «диалектов», поэтому функционал регулярных выражений может различаться от языка к языку (реализация регулярных выражений в C# совместима с PERL).
1. Регулярный Выражения
2. Регулярки в C#
# Вывод:
Ознакомившись с теоритеческим материалом мы сделали несколько задач:
1. Задание №1:
Console.WriteLine("Введите строку для поиска времени: ");

var time = Console.ReadLine();

Regex RegexExpretion = new Regex(@"([0][1-9]|[1][0-9]|[2][0-3]):([0-5][0-9])");

var Result = RegexExpretion.Match(time);


if (RegexExpretion.IsMatch(time))

{

Console.WriteLine(Result.Value);

}

else

{

Console.WriteLine("неккоректное время");

} 
```
Введите строку для поиска времени:
привет,я родилась в 13:45
13:45
```
2. Задание №2:

Console.WriteLine("Введите строку для поиска html цвета: ");

var html = Console.ReadLine();

Regex RegexExpretion = new Regex(@"#([0-9]|[A-F]){6}");

var Result = RegexExpretion.Match(html);

if(RegexExpretion.IsMatch(html))

{

Console.WriteLine(Result.Value);
}

else

{

Console.WriteLine("неккоректный цвет");

}

Console.ReadKey();
```
Введите строку для поиска html цвета:
мой любимый цвет #F08080
#F08080

```
3. Задание №3
Console.WriteLine("Введите строку для поиска арифметических операций: ");

var InpString = Console.ReadLine();

Regex RegexExpretion = new Regex(@"([-+]?(?:\d+(?:\.\d*)?|\.\d+)(?:[eE][-+]?\d+)?)([+]|[-]|[][\/]?)([-+]?(?:\d+(?:\.\d)?|\.\d+)(?:[eE][-+]?\d+)?)");

var Result = RegexExpretion.Match(InpString);

if (RegexExpretion.IsMatch(InpString))

{

Console.WriteLine(Result.Value);

}

else

{

Console.WriteLine("неккоректная строка");
}

Console.ReadKey();
```
Введите строку для поиска арифметических операций:
1000+1000
1000+1000
```
