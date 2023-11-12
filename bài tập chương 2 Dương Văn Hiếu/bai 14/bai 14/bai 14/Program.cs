using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace bai_14
{
    class bai14
    {
        int a, b;
        public bai14()
        {
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void phuongtrinhbacnhat()
        {
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phuong trinh vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem: " + x);
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            bai14 b14 = new bai14();
            b14.phuongtrinhbacnhat();
            Console.ReadKey();
        }
    }
}