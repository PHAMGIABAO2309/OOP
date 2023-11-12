using System;
namespace KETHUA
{
    class CHUNHAT
    {
        private double dai;
        private double rong;
        public CHUNHAT(double d, double r)
        {
            dai = d;
            rong = r;
        }
        public double DIENTICH()
        {
            return dai * rong;
        }
    }
    class VUONG : CHUNHAT
    {
        public VUONG(double canh) : base(canh, canh)
        {
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            double d, r;
            int chon;
            Console.Write("Hinh chu nhat (0) hinh vuong (1): ");
            chon = Convert.ToInt32(Console.ReadLine());
            if (chon == 1)
            {
                Console.Write("Nhap chieu dai canh: ");
                d = Convert.ToDouble(Console.ReadLine());
                VUONG v = new VUONG(d);
                Console.WriteLine("Dien tich hinh vuong la: {0}", v.DIENTICH());
            }
            else
            {
                Console.WriteLine("Nhap chieu dai hinh chu nhat: ");
                d = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap chieu rong hinh chu nhat: ");
                r = Convert.ToDouble(Console.ReadLine());
                CHUNHAT cn = new CHUNHAT(d, r);
                Console.WriteLine("Dien tich hinh chu nhat: {0} ", cn.DIENTICH());
            }    
        }
    }
}