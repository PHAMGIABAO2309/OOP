using System;
using System.Collections.Generic;
namespace bai
{
    class Diem
    {
        public float X { get; set; }
        public float Y { get; set; }
        public virtual void Nhap()
        {
            Console.Write("Nhap toa do X cua diem: ");
            X = float.Parse(Console.ReadLine());
            Console.Write("Nhap toa do Y cua diem: ");
            Y = float.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write("({0}, {1})", X, Y);
            Console.WriteLine();
        }
    }
    class DoanThang : Diem
    {
        public Diem A = new Diem();
        public Diem B = new Diem();
        public override void Nhap()
        {
            Console.WriteLine("Toa Do Diem A: ");
            A.Nhap();
            Console.WriteLine("Toa Do Diem B: ");
            B.Nhap();
        }
        public override void Xuat()
        {
            Console.Write("\n Toa Do Diem A: ");
            A.Xuat();
            Console.Write("Toa Do Diem B: ");
            B.Xuat();
        }
        public void TinhChuVi()
        {
            double doDai = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            Console.WriteLine("Do Dai Doan Thang la: " + doDai);
        }
    }
    class HinhTron : Diem
    {
        public Diem tam = new Diem();
        public double bankinh;
        public override void Nhap()
        {
            Console.WriteLine("\n Nhap toa do tam hinh tron: ");
            tam.Nhap();
            Console.WriteLine("Nhap ban kinh hinh tron: ");
            bankinh = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.Write("Toa Do Tam: ");
            tam.Xuat();
        }
        public void TinhDienTichHinhTron()
        {
            double dientich = Math.PI * Math.Pow(bankinh, 2);
            Console.WriteLine("Dien Tich Hinh Tron la: " + dientich);
        }
    }
    class HinhChuNhat : Diem
    {
        public Diem A = new Diem();
        public Diem B = new Diem();

        public override void Nhap()
        {
            Console.WriteLine("\n Toa Do o 2 goc doi dien nhau: ");
            Console.WriteLine("Toa Do Diem A: ");
            A.Nhap();
            Console.WriteLine("Toa Do Diem B: ");
            B.Nhap();
        }
        public override void Xuat()
        {
            Console.Write("Toa Do Diem A: ");
            A.Xuat();
            Console.Write("Toa Do Diem B: ");
            B.Xuat();
        }
        public void TinhDienTichHinhChuNhat()
        {
            double chieudai = Math.Abs(B.X - A.X);
            double chieurong = Math.Abs(B.Y - A.Y);
            double dientich = chieudai * chieurong;
            Console.WriteLine("Dien tich Hinh Chu Nhat la: " + dientich);
        }
    }
    class dshinhhoc
    {
        Diem[] ds;
        DoanThang[] ds2;
        HinhTron[] ds3;
        HinhChuNhat[] ds4;
        public void Nhapsoluongdoituong()
        {
            Console.WriteLine("Nhap so luong doi tuong hinh hoc: ");
            int n = int.Parse(Console.ReadLine());
            ds = new Diem[n];
            ds2 = new DoanThang[n];
            ds3 = new HinhTron[n];
            ds4 = new HinhChuNhat[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n Chon loai doi tuong (1 - Diem , 2 - Doan thang, 3 - Hinh tron, 4 - Hinh chu nhat):");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ds[i] = new Diem();
                        ds[i].Nhap();
                        ds[i].Xuat();
                        break;
                    case 2:
                        ds2[i] = new DoanThang();
                        ds2[i].Nhap();
                        ds2[i].Xuat();
                        ds2[i].TinhChuVi();
                        break;
                    case 3:
                        ds3[i] = new HinhTron();
                        ds3[i].Nhap();
                        ds3[i].Xuat();
                        ds3[i].TinhDienTichHinhTron();
                        break;
                    case 4:
                        ds4[i] = new HinhChuNhat();
                        ds4[i].Nhap();
                        ds4[i].Xuat();
                        ds4[i].TinhDienTichHinhChuNhat();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le !.");
                        break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dshinhhoc ds = new dshinhhoc();
            ds.Nhapsoluongdoituong();
            Console.ReadKey();
        }
    }
}

