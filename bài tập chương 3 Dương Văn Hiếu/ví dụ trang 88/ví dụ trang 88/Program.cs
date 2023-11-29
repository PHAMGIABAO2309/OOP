using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace vidutrang80
{
    class NhanVien
    {
        string hoten;
        string soCMND;
        string phong;
        double Luong;
        public virtual void Nhap()
        {
            Console.Write("\nNhap ho va ten nhan vien: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap so CMND: ");
            soCMND = Console.ReadLine();
            Console.Write("Nhap Phong: ");
            phong = Console.ReadLine();
            Console.Write("Nhap so tien luong: ");
            Luong = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write("{0} - {1} - {2} - {3} ", hoten, soCMND, phong, Luong);
        }
    }
    class NhanvienBienChe : NhanVien
    {
        int BacLuong;
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine(" - {0} ", BacLuong);
        }
    }
    class NhanVienHopDong : NhanVien
    {
        int sogio;
        int heso;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so gio: ");
            sogio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so: ");
            heso = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine(" - {0} - {1} ", sogio, heso);
        }
    }
    class DSNVBC
    {
        NhanvienBienChe[] DS;
        public void NhapDSNVBC()
        {
            int n;
            Console.WriteLine("Nhap so luong nhan vien bien ches: ");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new NhanvienBienChe[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n Nhap nhan vien bien che thu {0} :", i+1);
                DS[i] = new NhanvienBienChe();
                DS[i].Nhap();
                DS[i].Xuat();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DSNVBC nvbc = new DSNVBC();
            nvbc.NhapDSNVBC();
            
            
            Console.ReadKey();
        }
    }
}