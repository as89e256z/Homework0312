using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    class ReadFile
    {
        static void Read(string[] args)
        {
            string path = "C:\\Temp\\";
            string path1 = "C:\\Temp\\aaa.txt";

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
            string content = System.IO.File.ReadAllText(path1);
            Console.WriteLine(content+"\n已完成讀取");
            Console.ReadLine(); 
            } while (true);
        }
    }
}
