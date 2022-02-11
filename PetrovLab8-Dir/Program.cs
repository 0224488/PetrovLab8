using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PetrovLab8_Dir
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = "d:\\ТЕСТ\\";
            string[] dir = Directory.GetDirectories(dirName);
            foreach (string d in dir)
            {
                Console.WriteLine(d);
                string[] dir2 = Directory.GetDirectories(d);
                foreach (string d2 in dir2) 
                {
                    Console.WriteLine($"  {d2}");
                    string[] dir3 = Directory.GetDirectories(d2);
                    foreach (string d3 in dir3)
                    {
                        Console.WriteLine($"    {d3}");

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
