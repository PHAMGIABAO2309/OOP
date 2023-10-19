using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace baitap5
{
    class bai5
    {
        int n, x;
        double S;

        public bai5()
        {
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
        }
        int giaithua(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * giaithua(n - 1);
        }
        public double Tong()
        {
            S = 0;
            for (int i = 0; i <= n; i++)
            {
                S = S + (Math.Pow(x, i)) / giaithua(i);
            }
            return S;
        }
    }
    class bai6
    {
        int n;
        public bai6()
        {
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
    
        public void Tong6()
        {
            for(int i = 1; i<=n;i++)
            {
                if (n % i == 0)
                    Console.WriteLine("{0}",i);
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bai6 b6 = new bai6();
            b6.Tong6();
            Console.ReadKey();
        }
    }
}