using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace oap_labs_1

{

    class Program
    {
        static void drive()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {drive.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Director()
        {
            string DirName = "C:\\";
            if (Directory.Exists(DirName))
            {
                Console.WriteLine("Подкатологи");
                string[] dirs = Directory.GetDirectories(DirName);
                foreach (string a in dirs)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(DirName);
                foreach (string a in files)
                {
                    Console.WriteLine(a);
                }

            }
            Console.ReadLine();
        }
        static void Director1()
        {
            string Path = @"C:\SomeDir";
            string Popa = @"program\create";
            DirectoryInfo DirInfo = new DirectoryInfo(Path);
            if (!DirInfo.Exists)
            {
                DirInfo.Create();
            }
            DirInfo.CreateSubdirectory(Popa);
        }
        static void Direcotr2()
        {
            string dirName = "C:\\Program Files";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
        }
        static void Director3()
        {
            string dirName = @"C:\SomeFolder";

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Director4()
        {
            string oldPath = @"C:\SomeFolder";
            string newPath = @"C:\Dir";
            DirectoryInfo dirInfo = new DirectoryInfo(oldPath);
            if (dirInfo.Exists && Directory.Exists(newPath) == false)
            {
                dirInfo.MoveTo(newPath);
            }
        }
        static void Files1()
        {
            string path = @"C:\Delphi7\readme.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0}", fileInf.Length);
            }
        }
        static void Files2()
        {
            string path = @"C:\Delete\deleteMe.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
                // альтернатива с помощью класса File
                // File.Delete(path);
            }
        }
        static void Files3()
        {
            string path = @"C:\apache\readme.txt";
            string newPath = @"C:\SomeDir\readme.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.MoveTo(newPath);
                // альтернатива с помощью класса File
                // File.Move(path, newPath);
            }
        }
        static void Files4()
        {
            string path = @"C:\apache\hta.txt";
            string newPath = @"C:\SomeDir\hta.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath, true);
                // альтернатива с помощью класса File
                // File.Copy(path, newPath, true);
            }
        }
        static void Files5()
        {
            // создаем каталог для файла
            string path = @"C:\SomeDir2";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();

            // запись в файл
            using (FileStream fstream = new FileStream($"{path}\\note.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }

            // чтение из файла
            using (FileStream fstream = File.OpenRead($"{path}\\note.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }

        }
      
       
       

        static void Main(string[] args)
       {

            //drive();
            //Director();
            //Director1();
            // Direcotr2();
            //Director3();
            // Director4();
            // Files1();
            // Files2();
            // Files3();
             //Files4();
            Files5();
            
            Console.ReadKey();



        }

    }
}
        
    








                


            















