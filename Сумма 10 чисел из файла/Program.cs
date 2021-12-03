using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Сумма_10_чисел_из_файла
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            int s = 0;
            string path = "D:/Итмо проекты/Работа с файлом/Создание Папки/bin/Debug/Logs2/log.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int x = random.Next(10);
                    sw.WriteLine("{0} ", x);
                }
            }
            StreamReader f = new StreamReader(path);
            {
                for (int i = 0; i < 10; i++)
                {
                    int x = Convert.ToInt32(f.ReadLine());
                    s += x;
                }
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}














