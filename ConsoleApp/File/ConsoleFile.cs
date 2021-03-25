using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{ 
    class ConsoleFile
    {
        static void Main(string[]args)
        {
            Console.WriteLine("程式啟動");
            Console.ReadLine();
            string Option_one = "";//要使用的檔案所在目錄變數
            string Option_two = "";//使用後檔案儲存處
            string YN = "";//判斷User是否要繼續進行
            string order;//給User要用的方法選項


                do
                {
                    Console.WriteLine($"輸入要使用的檔案路徑{Option_one}\nC:\\Temp\\aaa.txt");
                    Option_one = Console.ReadLine();
                    Console.WriteLine($"輸入完成後檔案目的地{Option_two}\nD:\\Temp\\aaa.txt");
                    Option_two = Console.ReadLine();
                    Console.WriteLine("確認輸入Y/N");
                    YN = Console.ReadLine().ToUpper();
                } while ((YN != "Y" | YN == "YES") & (YN == "Y" | YN != "YES"));
            //當YN不等於Y/YES時自動默認為否，則返回迴圈，反之到下一區
            Console.WriteLine
                    ("輸入代號執行操作\n1.MoveFile 2.CopyFile 3.ReadFile 4.DeleteFile 5.CreateFolder 6.DeleteFolder");
                order = Console.ReadLine();
            bool number = order != "0";
            if (number)
            {
                switch (order)
                 {
                    case "1":
                        MoveFile.Move(Option_one, Option_two);
                        break;
                    case "2":
                        CopyFile.Copy(Option_one,Option_two);
                        break;
                    case "3":
                        ReadFile.Read(Option_one);
                        break;
                    case "4":
                        DeleteFile.Delete(Option_one);
                        break;
                    case "5":
                        CreateFolderFile.CreateFolder(Option_one);
                        break;
                    case "6":
                        DeleteFolderFile.DeleteFolder(Option_one);
                        break;
                    default:
                        Console.WriteLine("無此選項");
                        break;
                     }
                    Console.WriteLine("程式結束");
                    Console.ReadLine();
                    return;
            }
            else
            {
                return;
            }
        }
    }
}

 
