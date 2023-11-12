using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class BT8
    {
        private int n;
        private double x,c=0;
        public void Nhap()
        {
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap x:");
            x = Convert.ToDouble(Console.ReadLine());
        }
        public int GiaiThua(int n)
        {
            int g = 1;
            for (int i = 2; i <= n; i++)
            {
                g = g * i;
            }
            return g;
        }
        public double Mu(int n, double x)
        {
            double m = 1;
            for (int i = 1; i <= n; i++)
            {
                m = m * x;
            }
            return m;
        }
        public double Tinh(int n, double x)
        {
            
            for (int i = 1; i <= n; i++)
            {
                c = c + (Mu(i, x)) / GiaiThua(i);
            }
            return c;
        }
        public void Xuat()
        {
            c = Tinh(n, x);
            Console.Write("Kq = {0}", c);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BT8 bt8 = new BT8();
            bt8.Nhap();
            bt8.Xuat();
        }
    }
}