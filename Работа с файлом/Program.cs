using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Работа_с_файлом
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives=DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            { 
            Console.WriteLine("Название диска : {0}",d.Name);
                if(d.IsReady)
                {
                    Console.WriteLine("Объем диска : {0} ", d.TotalSize);
                    Console.WriteLine("Свободно места на диске : {0}", d.AvailableFreeSpace);
                }

            }
            Console.ReadKey();
        }
    }
}
