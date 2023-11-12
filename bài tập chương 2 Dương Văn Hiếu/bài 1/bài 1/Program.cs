using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
//S = 1 + 1/2 + 1/3 +...+1/n
namespace Chuong2_Bai1
{
    class Bai1
    {
        Int32 n; //số số hạng
        Double S; //Tổng
        public Bai1() // hàm xây dựng
        {
            Console.Write("Nhap so n= ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public Double TinhTong()
        {
            Int32 i;
            S = 0;
            for (i = 1; i <= n; i++)
                S = S + 1.0 / i;
            return S;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bai1 b = new Bai1();
            Console.WriteLine("Tong S= {0}", b.TinhTong());
            Console.ReadKey();
        }
    }
}