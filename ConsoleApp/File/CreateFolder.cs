using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace File
{
    class CreateFolder
    {
        static void Create(string[] args)
        {
            string path = "C:\\Temp\\temp";
            DateTime beforDT = System.DateTime.Now;

            do
            {
                Console.WriteLine("請按任意鍵繼續");
                Console.ReadLine();
                Console.ReadKey();
                if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("已建立資料夾");
                Console.ReadLine();
            }
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
                return;

            } while (true);
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            Console.WriteLine("DateTime總共花費(0)ms", ts.TotalMilliseconds);
        }
    }
}
