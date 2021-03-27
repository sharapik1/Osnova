<table style="width: 100%;">
  <tr>
    <td style="text-align: center; border: none;"> 
    Минестерство образования и науки РФ <br>
    ГБПОУ РМЭ "Йошкар-Олинский Технологический колледж </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;"><h2>Отчет по лабораторной работe<h2><br>
    По теме: Интерфейсы
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
2. Используя информацию из лекции создать интерфейс: АПИ: логин, логаут

# Краткий теоретический материал:
Как мы помним из лекций, интерфейсы позволяют уйти от сильного связывания кода. Т.е. вместо использования переменной конкретного класса (если вспомнить трансформеров, то вместо класса "винтовка" мы используем интерфейс "оружие") мы используем переменную типа интерфейс, которой может быть присвоен любой объект, который реализует этот интерфейс.
# Вывод: 
1. Мы разработали интерфейс:
```
 interface IAPI
    {
        bool Login(string name, string password);
        bool Logout();
    }
```
2. Реализовали его в сначала в классе Mock:
```
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
```
3. Далее реализовали в классе Authorization:
``` 
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
```
4. И реализовали в классе AuthorizationinFile:
``` 
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
```
