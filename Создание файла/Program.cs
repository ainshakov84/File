using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Создание_файла
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Итмо проекты/Работа с файлом/Создание Папки/bin/Debug/Logs2/log.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }



            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Программа запущена ");
                sw.WriteLine("Ошибка");
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}





