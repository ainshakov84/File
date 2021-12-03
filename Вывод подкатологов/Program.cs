using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Вывод_подкатологов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirName = "d:/итмо проекты/массив";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                  Console.WriteLine(s);
                      }
            Console.ReadKey();
        }
    }
}

