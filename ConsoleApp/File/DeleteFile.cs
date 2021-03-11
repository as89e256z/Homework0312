using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace File
{
    class DeleteFile
    {
        static void Delete(string[] args)
        {

            string path1 = "C:\\Temp\\aaa.txt";

            do
            {
                Console.WriteLine("請按任意鍵繼續");
                Console.ReadLine();
                Console.ReadKey();
                if (!Directory.Exists(path1))
            {
                Console.WriteLine($"{path1} doesn't exist;");
                Console.ReadLine();
                return;
            }
                System.IO.File.Delete(path1);
                Console.WriteLine("已完成刪除");
            Console.ReadLine(); 
            } while (true);
        }
    }
}
