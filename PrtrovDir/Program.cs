using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PetrovDir
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
                // Я бы хотел заметить, что так не честно! На данном шаге обучения, мы ещё не проходили исключения!
                // Формулировка в задаче "Выберите ЛЮБУЮ папку на своем компьютере" не корректна.
                // Попытка в программе в качестве "любой" выбрать например "C:\Users\" естественно прерывала программу!..
                // Попытка проверить существующая ли это папка не помогает в этом.
                // Долгие попытки решить эту проблему привели к необходимости воспользоваться исключениями...
            {
                Console.WriteLine(@"Введите полный путь и имя папки. Например C:\Users\Public\Pictures\");
                string dirName = Console.ReadLine();
                //if (Directory.Exists(dirName))
                //{
                    DirectoryInfo directory = new DirectoryInfo(dirName);
                    FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
                    foreach (FileInfo fileName in files)
                    {
                        Console.WriteLine(fileName.FullName);
                    }
                //}
                //else
                //{
                //    Console.WriteLine("Не существующая папка или путь");
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
