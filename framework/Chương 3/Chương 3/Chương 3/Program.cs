using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Chương_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter: Ghi file văn bản
            FileStream fs = new FileStream("taptin.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("Hello World!");
            sw.Flush();
            fs.Close();

            //streamreader: Đọc file văn bản
            fs = new FileStream("taptin.txt",FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
            fs.Close();

            //
            Console.ReadLine();
        }
    }
}
