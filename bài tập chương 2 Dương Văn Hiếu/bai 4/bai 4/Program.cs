using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace c2b4
{
    class bai4
    {
        Int32 n;
        Double S = 0;
        public bai4()
        {
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public double TinhTong()
        {
            for (int i = 1; i <= n; i++)
                S = S + (2 * i + 1);
            return S;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            bai4 p = new bai4();
            Console.WriteLine("Tong: {0}", p.TinhTong());
            Console.ReadKey();
        }
    }
}