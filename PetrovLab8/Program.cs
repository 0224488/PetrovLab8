using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PetrovLab8
{
    class Program
    {
        static void Main(string[] args)
        { //Выберите любую папку на своем компьютере, имеющую вложенные директории.
          //Выведите на консоль ее содержимое и содержимое всех подкаталогов.
            try
            // Я бы хотел заметить, что так не честно! На данном шаге обучения, мы ещё не проходили исключения!
            // Формулировка в задаче "Выберите ЛЮБУЮ папку на своем компьютере" не корректна.
            // Понимаю, вы не учитываете того, что у пользователя могут быть ограниченные права на компьютере.
            // Попытка в программе в качестве "любой" выбрать например "C:\Users\", в моём случае прерывала программу!
            // Попытка проверить существующая ли это папка не помогает в этом.
            // Долгие попытки решить эту проблему привели к необходимости воспользоваться исключениями.
            // Другой способ - обращаться к папке к которой заведомо есть доступ, в т.ч. к подкаталогам и файлам.
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
            catch (Exception bugName)
            {
                Console.WriteLine(bugName.Message);
            }

            Console.ReadKey();
        }
    }
}
