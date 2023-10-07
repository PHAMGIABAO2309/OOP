using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace c2_bai2
{
    class bai2
    {
        Int32 n;
        Double S = 0;
        public bai2()
        {
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public Double TinhTong()
        {
            for (int i = 1; i <= n; i++)
                S = S + Math.Pow(i, 3);
            return S;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            bai2 p = new bai2();
            Console.WriteLine("Tong S= {0}", p.TinhTong());
            Console.ReadKey();
        }
    }
}