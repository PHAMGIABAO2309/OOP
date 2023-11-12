using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai_15
{
    class bai15
    {
        int a, b,c;
        double delta;
        public bai15()
        {
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
        }
        public void phuongtrinhbachai()
        {
            delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem la: ");
                double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("x1= " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            if ( delta == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("Phuong trinh co nghiem kep: " + x);
            }
            else if ( delta < 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            bai15 b15 = new bai15();
            b15.phuongtrinhbachai();
            Console.ReadKey();
        }
    }
}