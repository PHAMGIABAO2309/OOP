using System;

namespace TAMGIAC
{
    class DIEM
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public DIEM()
        {
            Console.Write("Nhap x = ");
            X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap y = ");
            Y = Convert.ToDouble(Console.ReadLine());
        }

        public DIEM(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public static bool operator ==(DIEM p, DIEM q)
        {
            return p.X == q.X && p.Y == q.Y;
        }

        public static bool operator !=(DIEM p, DIEM q)
        {
            return !(p == q);
        }
        public void Xuat()
        {
            Console.WriteLine("({0:F1},{1:F1})", x, y);
        }
    }

    class TamGiac
    {
        private DIEM A, B, C;
        private DIEM trongTam, trucTam, ngoaiTiep;
        double ChuVi, DienTich;


        public TamGiac()
        {
            do
            {
                Console.WriteLine("Nhap toa do diem A:");
                A = new DIEM();
                Console.WriteLine("Nhap toa do diem B:");
                B = new DIEM();
                Console.WriteLine("Nhap toa do diem C:");
                C = new DIEM();
            } while (A == B || B == C || A == C);

        }

        public void Xuat()
        {
            Console.Write("A: ");
            A.Xuat();
            Console.Write("B: ");
            B.Xuat();
            Console.Write("C: ");
            C.Xuat();
            Console.Write("Toa do trong tam: ");
            trongTam.Xuat();
            Console.Write("Toa do truc tam: ");
            trucTam.Xuat();
            Console.Write("Toa do tam ngoai tiep: ");
            ngoaiTiep.Xuat();
            Console.WriteLine("Chu vi tam giac: {0:F2}", ChuVi);
            Console.WriteLine("Dien tich tam giac: {0:F2}", DienTich);



        }


        public void ToaDoTrongTam()
        {
            double gtx, gty;
            gtx = (A.X + B.X + C.X) / 3.0;
            gty = (A.Y + B.Y + C.Y) / 3.0;
            trongTam = new DIEM(gtx, gty);
        }


        public void ToaDoTrucTam()
        {
            double a = B.Y - C.Y;
            double b = C.X - B.X;
            double c = B.X * C.Y - B.Y * C.X;

            double d1 = A.X * a + A.Y * b + c;
            double d2 = (B.X + C.X) * a / 2.0 + (B.Y + C.Y) * b / 2.0 + c;


            double Ix = -1 * (d1 * b - d2 * a) / (a * a + b * b);
            double Iy = -1 * (d1 * b + d2 * a) / (a * a + b * b);
            trucTam = new DIEM(Ix, Iy);

        }

        public void ToaDoTamNgoaiTiep()
        {
            double x1 = A.X, y1 = A.Y;
            double x2 = B.X, y2 = B.Y;
            double x3 = C.X, y3 = C.Y;

            double D = 2 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            double z1 = x1 * x1 + y1 * y1;
            double z2 = x2 * x2 + y2 * y2;
            double z3 = x3 * x3 + y3 * y3;

            double Ox = ((x1 * x1 + y1 * y1) * (y2 - y3) + (x2 * x2 + y2 * y2) * (y3 - y1) + (x3 * x3 + y3 * y3) * (y1 - y2)) / D;
            double Oy = ((x1 * x1 + y1 * y1) * (x3 - x2) + (x2 * x2 + y2 * y2) * (x1 - x3) + (x3 * x3 + y3 * y3) * (x2 - x1)) / D;
            ngoaiTiep = new DIEM(Ox, Oy);
        }

        public double KhoangCach(DIEM p, DIEM q)
        {
            double dx = p.X - q.X;
            double dy = p.Y - q.Y;

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }


        public void TinhChuVi()
        {
            double canhAB = KhoangCach(A, B);
            double canhBC = KhoangCach(B, C);
            double canhAC = KhoangCach(A, C);

            ChuVi = canhAB + canhBC + canhAC;
        }

        public void TinhDienTich()
        {
            double canhAB = KhoangCach(A, B);
            double canhBC = KhoangCach(B, C);
            double canhAC = KhoangCach(A, C);

            double p = (canhAB + canhBC + canhAC) / 2;

            DienTich = Math.Sqrt(p * (p - canhAB) * (p - canhBC) * (p - canhAC));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TamGiac tamGiac = new TamGiac();
            tamGiac.ToaDoTrongTam();
            tamGiac.ToaDoTrucTam();
            tamGiac.ToaDoTamNgoaiTiep();
            tamGiac.TinhChuVi();
            tamGiac.TinhDienTich();
            tamGiac.Xuat();



            Console.ReadKey();
        }
    }
}
