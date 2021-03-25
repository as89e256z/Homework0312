using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class CopyFile
    {
        public static void Copy(string path1,string path2)
       {
            string Newname = Path.GetDirectoryName(path2) + "\\" + Path.GetFileNameWithoutExtension(path2) + Path.GetExtension(path2);
            /*Path.GetDirectoryName 目錄路徑(除去目標檔案的上一層路徑) Path.GetFileNameWithoutExtension 目標檔案(不附副檔名  Path.GetExtension 目標檔案的副檔名(只有副檔名*/

            if (File.Exists(Newname))
            {
                do
                {
                    Newname = Path.GetDirectoryName(Newname) + "\\" + Path.GetFileNameWithoutExtension(Newname) + Path.GetExtension(Newname);
                    Console.WriteLine($"{Newname} doesn't exist;");
                   
                } while (File.Exists(Newname));
                
            }
            DateTime startTime = DateTime.Now;

            File.Copy(path1, path2);
            DateTime endTime = DateTime.Now;
            TimeSpan ts = endTime - startTime;
            Console.WriteLine($"已複製檔案至{Newname}，共花費{ts.TotalSeconds}秒，按ENTER鍵繼續");

        }
    }
 }
