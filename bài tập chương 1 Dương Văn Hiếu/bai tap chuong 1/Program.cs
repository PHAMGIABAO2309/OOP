using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace baihieu
{
    class Program
    {

        static double bai1(int n)//S=1+1/2 +1/3 + 1/n
        {
            int i;
            double S = 0;
            for (i = 1; i <= n; i++)
                S = S + (1.0) / i;
            return S;
        }
        static double bai2(int n) //S=1^3 + 2^3 + n^3
        {
            int i;
            double S = 0;
            for (i = 1; i <= n; i++)
                S = S + Math.Pow(i, 3);
            return S;
        }
        static double bai3(int x, int n) // T = x^n
        {
            double T = 1;
            for (int i = 1; i <= n; i++)
                T = T * x;
            return T;
        }
        static double bai4(int n)
        {
            double S = 0;
            for (int i = 1; i <= n; i++)
                S = S + (2 * i + 1);
            return S;
        }
        static double bai5(int n)
        {
            double S = 0;
            for (int i = 0; i <= n; i++)
                S = S + (i * (i + 1) * (i + 2));
            return S;
        }
        static double bai6(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write("{0}\t", i);
            }
            return n;
        }
        static double bai7(int x, int n)
        {
            double S = 0;
            for (int i = 1; i <= n; i++)
                S = S + Math.Pow(x, i);
            return S;
        }

        static double bai8(int x, int n) //S=x^1/1! + x^2/2! + x^n/n!
        {
            double S = 0;
            double factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;
            S = S + Math.Pow(x, n) / factorial;
            return S;
        }
        static double bai9(int n) // liet ke all cac uoc so le cua so nguyen duong n
        {
            for (int i = 1; i <= n; i += 2)
            {
                if (n % i == 0) // kiem tra neu i la uoc so cua n
                {
                    Console.WriteLine("{0}\t", i);
                }
            }
            return n;
        }
        static double bai10(int n) // liet ke all cac uoc so chan cua so nguyen duong n
        {
            for (int i = 2; i <= n / 2; i += 2)
            {
                if (n % i == 0) // kiem tra neu i la uoc so cua n
                {
                    Console.WriteLine("{0}\t", i);
                }
            }
            return n;
        }
        static double bai11(int n)
        {
            double S = 0;
            for (int i = 1; i <= n; i++)
                S = S + Math.Sqrt(i + Math.Sqrt((i - 1) + Math.Sqrt(2 + Math.Sqrt(1))));
            return S;
        }
        static int bai12(int a, int b) // tim uoc so chung lon nhat
        {
            int USCLN;
            USCLN = Math.Min(a, b);
            for (int i = 1; i <= USCLN; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    USCLN = i;
                }
            }
            return USCLN;

        }    

        static double bai13(int n, int count)
        {

            //int count = 0;
            for (int i = 0; i <= n; i++)
                n /= 10;
            count++;

            return count;
        }
        static void bai14(double a, double b) // giai phuong trinh ax+b=0
        {
            if (a == 0 )
            {
                if( b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem x= {0}  ",x);
            }
        }
        static void bai15(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if(delta > 0 )
            {
                double x1 = (-b + Math.Sqrt(delta))/(2*a);
                double x2 = (-b - Math.Sqrt(delta) )/ (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem: ");
                Console.WriteLine("x1= {0} ", x1);
                Console.WriteLine("x2= {0} ", x2);
            }
            else if ( delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: ");
                Console.WriteLine("x= {0}" ,x);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        static void Main(string[] args)
        {
            //Console.Write("Nhap n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap x = ");
            //int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap c = ");
            //double c = Convert.ToDouble(Console.ReadLine());
            int USCLN = bai12(a, b);
            //Console.WriteLine("Tong S = {0}", bai8(n, x));
            Console.WriteLine("Uoc so chung lon nhat cua {0) va {1} la: {2} ",a,b,USCLN);
            Console.ReadKey();
        }
    }
}