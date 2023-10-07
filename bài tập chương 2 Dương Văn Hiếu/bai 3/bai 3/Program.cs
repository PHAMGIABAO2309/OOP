using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace c2bai3
{
    class bai3
    {
        Int32 n;
        Double T , x;
        public bai3()
        {
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap x= ");
            x = Convert.ToDouble(Console.ReadLine());

        }
        public Double TinhTong()
        {
            T = 1;
            for (int i = 1; i <= n; i++)
                T = T * x;
            return T;
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            bai3 p = new bai3();
            Console.WriteLine("Tong T= {0} ", p.TinhTong());
            Console.ReadKey();
        }
    }
}