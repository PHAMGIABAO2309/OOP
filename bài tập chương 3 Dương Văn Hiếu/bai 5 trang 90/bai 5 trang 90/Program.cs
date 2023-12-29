using System;

namespace bai5
{
    class dientro
    {
        public double r { get; set; }

        public virtual void nhap()
        { }
    }

    class machnoitiep : dientro
    {
        public override void nhap()
        {
            base.nhap();

            Console.WriteLine("Nhap dien tro R mach noi tiep: ");
            r = Convert.ToDouble(Console.ReadLine());
        }

        public double tongmachnoitiep()
        {
            double tong = 0.0;
            for (int i = 0; i <= r; i++)
            {
                tong = tong + (double)i;
            }
            return tong;
        }
    }

    class machsongsong : dientro
    {
        public override void nhap()
        {
            base.nhap();

            Console.WriteLine("Nhap dien tro R mach song song: ");
            r = Convert.ToDouble(Console.ReadLine());
        }
        public double tongmachsongsong()
        {
            double tongss = 0.0;
            for (int i = 1; i <= r; i++)
            {
                tongss += 1 / (double)i;
            }
            tongss = 1 / tongss;
            return tongss;
        }
    }

    class soluong
    {
        dientro[] dt;
        machnoitiep[] nt;
        machsongsong[] ss;

        public void nhapsoluong()
        {
            Console.WriteLine("Nhap so luong dien tro: ");
            int n = int.Parse(Console.ReadLine());
            dt = new dientro[n];
            nt = new machnoitiep[n];
            ss = new machsongsong[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap gia tri dien tro " + (i + 1) + ": ");
                dt[i] = new dientro();
                nt[i] = new machnoitiep();
                nt[i].nhap();
                double tongnt = nt[i].tongmachnoitiep();
                Console.WriteLine("Tong mach noi tiep: " + tongnt);

                ss[i] = new machsongsong();
                ss[i].nhap();
                double tongss = ss[i].tongmachsongsong();
                Console.WriteLine("Tong mach song song: " + tongss);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            soluong sl = new soluong();
            sl.nhapsoluong();
            Console.ReadKey();
        }
    }
}
