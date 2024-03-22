using System;
namespace hbh
{
    class DIEM
    {
        private double x, y;
        public void Nhap()
        {
            Console.Write("Nhap x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine(" ( {0}, {1} )", x, y);
        }
        public double Layx()
        {
            return x;
        }
        public double Layy()
        {
            return y;
        }
        public void Ganx(double xx)
        {
            x = xx;
        }
        public void Gany(double yy)
        {
            y = yy;
        }
        public static bool operator ==(DIEM a, DIEM b)
        {
            return (a.x == b.x && a.y == b.y);
        }
        public static bool operator !=(DIEM a, DIEM b)
        {
            return (a.x != b.x && a.y != b.y);
        }
       

    }
    class HINHBINHHANH
    {
        DIEM A = new DIEM();
        DIEM B = new DIEM();
        DIEM C = new DIEM();
        DIEM D = new DIEM();
        DIEM O = new DIEM();
        public void Nhap()
        {
            Console.WriteLine("Toa do A: ");
            A.Nhap();
            do
            {
                Console.Write("Toa do B: ");
                B.Nhap();
            } while (A == B);
            do
            {
                Console.WriteLine("Toa do O: ");
                O.Nhap();
            } while (O == A || O == B);
        }
        public void Xuat()
        {
            Console.WriteLine("Toa do A: ");
            A.Xuat();
            Console.WriteLine("Toa do B: ");
            B.Xuat();
            Console.WriteLine("Toa do O: ");
            O.Xuat();
            TimCvaD();
            Console.WriteLine("Toa do C: ");
            C.Xuat();
            Console.WriteLine("Toa do D: ");
            D.Xuat();
            
            Console.WriteLine("Chu vi hbh: {0}",TinhChuVi());
            
            
        }
        public void TimCvaD()
        {
            C.Ganx(2 * O.Layx() - A.Layx());
            C.Gany(2 * O.Layy() - A.Layy());
            D.Ganx(2 * O.Layx() - B.Layx());
            D.Gany(2 * O.Layy() - B.Layy());
        }
        public double TinhChuVi()
        {
            double AB,BC;
            AB = Math.Sqrt(Math.Pow(B.Layx() - A.Layx(), 2) + Math.Pow(B.Layy() - A.Layy(), 2));

            
            BC = Math.Sqrt(Math.Pow(C.Layx() - B.Layx(), 2) + Math.Pow(C.Layy() - B.Layy(), 2));
            return (AB + BC) * 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HINHBINHHANH hbh = new HINHBINHHANH();
            hbh.Nhap();
            hbh.Xuat();
            Console.ReadKey();
        }
    }
}