using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace tamgiac
{
    class DIEM
    {
        double x;
        double y;
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
        public void Nhap()
        {
            Console.Write("\nNhap tung do x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap hoanh do y: ");
            y = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine(" ( {0},{1} )", x, y);
        }
        public static bool operator ==(DIEM A, DIEM B)
        {
            return (A.x == B.x && A.y == B.y);
        }
        public static bool operator !=(DIEM A, DIEM B)
        {
            return (A.x != B.x && A.y != B.y);
        }
    }
    class TAMGIAC
    {
        DIEM A = new DIEM();
        DIEM B = new DIEM();
        DIEM C = new DIEM();
        public void Nhap()
        {
            Console.Write("Toa do diem A: ");
            A.Nhap();
            do
            {
                Console.Write("Toa do diem B: ");
                B.Nhap();
            } while (A == B);
            do
            {
                Console.Write("Toa do diem C: ");
                C.Nhap();
            } while (C == A || C == B);
            canhAB = Canh(A, B);
            canhBC = Canh(B, C);
            canhAC = Canh(A, C);
        }
        DIEM tamngoaitiep = new DIEM();
        double canhAB, canhBC, canhAC;
        double r;
        double cvtg, dttg, cvdt, dtdt;
        public double Canh(DIEM A, DIEM B)
        {
            double x, y, kq;
            x = A.Layx() - B.Layx();
            y = A.Layy() - B.Layy();
            return Math.Sqrt(x * x + y * y);
        }
        
        public double ChuViTamGiac()
        {
            canhAB = Canh(A, B);
            canhBC = Canh(B, C);
            canhAC = Canh(A, C);
            return canhAB + canhBC + canhAC;
        }
        public double DienTichTamGiac()
        {
            double p;
            p = (canhAB + canhBC + canhAC) / 2;
            return Math.Sqrt(p * (p - canhAB) * (p - canhBC) * (p - canhAC));
        }
        public void TamNT()
        {
            double x1, x2, x3, y1, y2, y3;
            x1 = A.Layx(); y1 = A.Layy();
            x2 = B.Layx(); y2 = B.Layy();
            x3 = C.Layx(); y3 = C.Layy();

            double D = 2 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            double z1, z2, z3;
            z1 = x1 * x1 + y1 * y1;
            z2 = x2 * x2 + y2 * y2;
            z3 = x3 * x3 + y3 * y3;

            double Ox, Oy;
            Ox = (z1 * (y2 - y3) + z2 * (y3 - y1) + z3 * (y1 - y2)) / D;
            Oy = (z1 * (x3 - x2) + z2 * (x1 - x3) + z3 * (x2 - x1)) / D;

            tamngoaitiep.Ganx(Ox);
            tamngoaitiep.Gany(Oy);
        }
        public double BanKinhNT()
        {
            dttg = DienTichTamGiac();
            return (canhAB * canhBC * canhAC) / (4 * dttg);
        }
        public double ChuViDT()
        {
            return 2 * 3.14 * r;
        }
        public  double DienTichDT()
        {
            return 3.14 * r * r;
        }
        public void Tinh()
        {
            cvtg = ChuViTamGiac();
            dttg = DienTichTamGiac();
            TamNT();
            r = BanKinhNT();
            cvdt = ChuViDT();
            dtdt = DienTichDT();
        }
        public void Xuat()
        {
            Console.WriteLine("Toa do A: ");
            A.Xuat();
            Console.WriteLine("Toa do B: ");
            B.Xuat();
            Console.WriteLine("Toa do C: ");
            C.Xuat();
            Console.WriteLine("Canh AB: {0}", canhAB);
            Console.WriteLine("Canh BC: {0}", canhBC);
            Console.WriteLine("Canh AC: {0}", canhAC);
            Console.WriteLine("Chu vi tam giac: {0}", cvtg);
            Console.WriteLine("Dien Tich Tam Giac: {0}", dttg);
            Console.WriteLine("Tam duong tron ngoai tiep 0: ");
            tamngoaitiep.Xuat();
            Console.WriteLine("Ban kinh duong tron ngoai tiep: {0}", r);
            Console.WriteLine("Chu Vi Duong Tron Ngoai Tiep: {0}", cvdt);
            Console.WriteLine("Dien Tich Duong Tron Ngoai Tiep: {0}", dtdt);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TAMGIAC TG = new TAMGIAC();
            TG.Nhap();
            TG.Tinh();
            TG.Xuat();
            Console.ReadKey();
        }
    }
}