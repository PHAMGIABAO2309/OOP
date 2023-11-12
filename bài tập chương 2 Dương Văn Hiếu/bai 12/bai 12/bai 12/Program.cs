using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace bai_12
{
    class bai12
    {
        int a, b;
        public bai12()
        {
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void USCLN()
        {
            while (b != 0)
            {
                int tam = b;
                b = a % b;
                a = tam;
            }
            Console.WriteLine("uoc so chung lon nhat la: " + a);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            bai12 b12 = new bai12();
            b12.USCLN();
            Console.ReadKey();
        }
    }
}