<table style="width: 100%;">
  <tr>
    <td style="text-align: center; border: none;"> 
    Минестерство образования и науки РФ <br>
    ГБПОУ РМЭ "Йошкар-Олинский Технологический колледж </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;"><h2>Отчет по лабораторной работe<h2><br>
    По теме: Исключения 
    </td>
  </tr>
  <tr>
    <td style="text-align: right; border: none; height: 20em;">
      Разработала: Шарапова Екатерина<br/>
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
1. Ознакомиться с общими сведениями о программах.
2. Практика с Исключениями
# Краткий теоретический материал:
1. Работа с дисками
2. Работа с каталогами
3. Работа с файлами. Классы File и FileInfo
4. FileStream. Чтение и запись файла
5. Бинарные файлы. BinaryWriter и BinaryReader
6. Бинарная сериализация. BinaryFormatter
# Вывод:
1. Я получила имена и свойства дисков на копьютере:
```
Название: C:\
Тип: Fixed
Объем диска: 239398281216
Свободное пространство: 151693197312
Метка:

Название: Z:\
Тип: Network

```
2. Вывела списки файлов и подкатологов
```
Подкатологи
C:\$Recycle.Bin
C:\$WinREAgent
C:\apache
C:\C-21
C:\Delete
C:\Delphi7
C:\Dir
C:\Documents and Settings
C:\EN.LPROJ
C:\FAR3
C:\GTK1
C:\i21
C:\Inprise
C:\Intel
C:\JAVASCRIPTCORE.RESOURCES1
C:\PABCWork.NET
C:\PerfLogs
C:\Program Files
C:\Program Files (x86)
C:\ProgramData
C:\Python27
C:\Recovery
C:\repozitor
C:\SomeDir
C:\SomeDir2
C:\SomeDir3
C:\System Volume Information
C:\Users
C:\Windows
C:\Новая папка
C:\Новая папка (2)

Файлы
C:\DumpStack.log.tmp
C:\hiberfil.sys
C:\pagefile.sys
C:\swapfile.sys
```
3. Создавала каталог   
```
string Path = @"C:\SomeDir";
DirectoryInfo DirInfo = new DirectoryInfo(Path);
```
4. Получала информацию о каталоге
```
DirectoryInfo dirInfo = new DirectoryInfo(dirName);
Название каталога: Program Files
Полное название каталога: C:\Program Files
Время создания каталога: 07.12.2019 12:14:52
Корневой каталог: C:\

```
5. Удаляла каталог
```
DirectoryInfo dirInfo = new DirectoryInfo(dirName);
dirInfo.Delete(true);
Каталог удален
```
6. Перемещала каталог:
```
DirectoryInfo dirInfo = new DirectoryInfo(oldPath);
```
7. Получала информацию о файле:
```
Имя файла: readme.txt
Время создания: 10.12.2020 14:30:55
Размер: 22317
```
8. Удаляла файл:
```
FileInfo fileInf = new FileInfo(path);
if (fileInf.Exists)
{
fileInf.Delete();
}
```
9. Перемещала файлы fileInf.MoveTo(newPath);
```
Файл перемещен
```
10. Вводила строку в файл:
```
Введите строку для записи в файл:
Привет
Текст записан в файл
Текст из файла: Привет
```


