using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    class CopyFile
    {
        static void Copy(string[] args)
       {
            string path = "C:\\Temp\\";
            do
            {
                Console.WriteLine("請按任意鍵繼續");
                Console.ReadLine();
                Console.ReadKey();
            if (System.IO.File.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
                return;
            }
            string path1 = "C:\\Temp\\aaa.txt";
            string path2 = "D:\\Temp\\aaa.txt";
            System.IO.File.Copy(path1, path2);
            Console.WriteLine("已完成複製");
            Console.ReadLine();
            } while (true);
        }
    }
 }
