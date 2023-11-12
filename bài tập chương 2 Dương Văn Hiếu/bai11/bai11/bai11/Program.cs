using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace bai_11
{
    class bai11
    {
        int n;
        double  S;
        public bai11()
        {
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void TinhS()
        {
            for(int i = 1; i<=n; i++)
            {
                S = Math.Sqrt(i + S);
            }
            Console.WriteLine("S= " + S);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            bai11 b11 = new bai11();
            b11.TinhS();
            Console.ReadKey();
        }
    }
}