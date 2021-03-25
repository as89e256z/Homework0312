using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Files
{
    class CreateFolderFile
    {
        public static void CreateFolder(string path1)
        {
            string Newname = Path.GetDirectoryName(path1) + "\\" + Path.GetFileNameWithoutExtension(path1) + Path.GetExtension(path1);
            /*Path.GetDirectoryName 目錄路徑(除去目標檔案的上一層路徑) Path.GetFileNameWithoutExtension 目標檔案(不附副檔名  Path.GetExtension 目標檔案的副檔名(只有副檔名*/

            if (Directory.Exists(Newname))
            {
                do
                {
                    Newname = Path.GetDirectoryName(Newname) + "\\" + Path.GetFileNameWithoutExtension(Newname) + Path.GetExtension(Newname);
                    Console.WriteLine($"{Newname} doesn't exist;");
                    return;
                } while (File.Exists(Newname));
            }
            DateTime startTime = DateTime.Now;

            Directory.CreateDirectory(Newname);
            DateTime endTime = DateTime.Now;
            TimeSpan ts = endTime - startTime;
            Console.WriteLine($"已建立資料夾{Newname}，共花費{ts.TotalSeconds}秒，按ENTER鍵繼續");


        }
    }
}
