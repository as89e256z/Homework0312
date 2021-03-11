using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;



namespace File
{
    class DeleteFolder
    {
        
        static void Delete(string[] args)
        {
            Stopwatch SW = new Stopwatch();//新增監控程式碼的stopwatch
            SW.Reset();//歸零
            SW.Start();//開始使用
            //目標程式碼
            string path = "C:\\Temp\\temp";


            
            do
            {
                Console.WriteLine("請按任意鍵繼續");
                Console.ReadLine();
                Console.ReadKey();
                if (!Directory.Exists(path))
            {
                    Console.WriteLine($"{path} doesn't exist;");
                    Console.ReadLine();
                    return;

                }
                    Directory.Delete(path);
                    Console.WriteLine("已刪除資料夾");
                    Console.ReadLine();

            } while (true);
            int number = 0;
            for(int i =0;i<=999999;i=i+1)
            {
                number = i;
            }
            //計算以上程式碼的執行時間
            SW.Stop();//停止
            //Elapsed Microsoft Docs定義為:取得目前執行個體所測量的已耗用時間
            //TotalMilliseconds 是總共用了幾毫秒 / 1000 是=幾秒 .ToString("f4")是因為原本是int要轉換成字串且只顯示小數點下四位
            string result = ((SW.Elapsed.TotalMilliseconds) / 1000).ToString("f4");
            string newresult = (SW.Elapsed.TotalSeconds).ToString();
            Console.WriteLine(number + "cost time: " + result);
            Console.WriteLine(newresult);
        }
    }
}
