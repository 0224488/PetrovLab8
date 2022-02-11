using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PetrovLab8_2
{
    class Program
    { //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
      //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string fileName = "D:/Petr01.txt"; //У меня на компе ограниченные права поэтому такой путь 
            int S = 0;
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(0,10)); // загружаем числа в файл, ограничиваем их диапазоном от 0 до 10
                }
            }
            using (StreamReader Z = new StreamReader(fileName))
            {
                for (int j = 0; j < 10; j++)
                {
                    S += Convert.ToInt32(Z.ReadLine());//выгружаем, конвертируем и суммируем.
                }
                Console.WriteLine($"Сумма чисел = {S}");
            }
            // После нажатия любой клавиши программа завершится и созданный файл будет удален!
            Console.ReadKey();
            File.Delete(fileName); // Ну и автоматически удалим файл.              
        }
    }
}
