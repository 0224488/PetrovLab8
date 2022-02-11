using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PetrovLab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = "d:\\ТЕСТ\\";
            // если папка существует
            if (Directory.Exists(dirName))
            {
                //Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine("Подкаталог {0}",s);
                    //Console.WriteLine("Файлы:");
                    string[] files = Directory.GetFileSystemEntries(s);
                    foreach (string f in files)
                    {
                        //Console.WriteLine();
                        //Console.WriteLine("Файлы:");
                        //string[] files = Directory.GetFiles(dirName);
                        Console.WriteLine("Файл {0}",f);
                    }
                }
                //Console.WriteLine();
                //Console.WriteLine("Файлы:");
                //string[] files = Directory.GetFiles(dirName);
                //foreach (string s in files)
                //{
               //     Console.WriteLine(s);
                //}
            }
            Console.ReadKey();
        }
    }
}
