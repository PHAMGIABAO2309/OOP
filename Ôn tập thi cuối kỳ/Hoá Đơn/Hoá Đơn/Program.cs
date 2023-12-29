using System;
namespace nguyenduchuy
{
    class ChiTietHoaDon
    {
        string MaHang, TenHang;
        int DonGia = 2000000;
        int SoLuong;
        int ThanhTien;
        public void Nhap()
        {
            Console.Write("Nhap Ma Hang: ");
            MaHang = Console.ReadLine();
            Console.Write("Nhap Ten Hang: ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap So Luong: ");
            SoLuong = Convert.ToInt32(Console.ReadLine());
        }
        public int TinhThanhTien()
        {
            ThanhTien = SoLuong * DonGia;
            return ThanhTien;
        }
        public void Xuat()
        {
            Console.WriteLine("Ma Hang:{0,-15} Ten Hang: {1,-20} So Luong: {2,-15} ThanhTien: {3,-5}d", MaHang, TenHang, SoLuong, TinhThanhTien());
        }

    }
    class HoaDon
    {
        int SoHoaDon;
        string Ngay;
        string KhachHang;
        ChiTietHoaDon[] dsCTHD;
        int SoDongChiTietHoaDon;
        int TongTien;
        public void NhapHoaDon()
        {
            Console.WriteLine("\nNhap So Hoa Don: ");
            SoHoaDon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Ngay: ");
            Ngay = Console.ReadLine();
            Console.WriteLine("Nhap Ten Khach Hang: ");
            KhachHang = Console.ReadLine();
            Console.WriteLine("\nNhap So Dong Chi Tiet Hoa Don: ");
            SoDongChiTietHoaDon = Convert.ToInt32(Console.ReadLine());

            dsCTHD = new ChiTietHoaDon[SoDongChiTietHoaDon];
            for (int i = 0; i < SoDongChiTietHoaDon; i++)
            {
                dsCTHD[i] = new ChiTietHoaDon();
                dsCTHD[i].Nhap();
                TongTien += dsCTHD[i].TinhThanhTien();
            }
        }
        public void XuatHoaDon()
        {
            Console.WriteLine("So Hoa Don: {0,-5} Ngay: {1,-20} Khach Hang: {2,-5}", SoHoaDon, Ngay, KhachHang);
            for (int i = 0; i < SoDongChiTietHoaDon; i++)
            {
                dsCTHD[i].Xuat();
            }
            Console.WriteLine("\nTong Tien Hoa Don: {0}đ\n", TongTien);
        }
        public int TongTienHoaDon()
        {
            return TongTien;
        }

    }
    class cuahang
    {
        string TenCH, DiaChiCH;
        HoaDon[] dsHD;
        int SoLuongHoaDon;
        int TongTienBan;
        public void NhapCuaHang()
        {
            Console.WriteLine("Nhap Ten Cua Hang: ");
            TenCH = Console.ReadLine();
            Console.WriteLine("Nhap Dia Chi Cua Hang: ");
            DiaChiCH = Console.ReadLine();
            Console.WriteLine("\nNhap So Luong Hoa Don: ");
            SoLuongHoaDon = Convert.ToInt32(Console.ReadLine());
            dsHD = new HoaDon[SoLuongHoaDon];

        }
        public void TinhTongTienBan()
        {
            for (int i = 0; i < SoLuongHoaDon; i++)
            {
                dsHD[i] = new HoaDon();
                dsHD[i].NhapHoaDon();
                TongTienBan += dsHD[i].TongTienHoaDon();
            }
        }
        public void XuatCuaHang()
        {
            Console.WriteLine("\nTen Cua Hang: {0,-15} Dia Chia Cua hang {1,-20} ", TenCH, DiaChiCH);
            Console.WriteLine("Danh Sach Hoa Don: ");
            for (int i = 0; i < SoLuongHoaDon; i++)
            {
                dsHD[i].XuatHoaDon();
            }
            Console.WriteLine("\n Tong Tien Ban Hang: {0}d", TongTienBan);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cuahang ch = new cuahang();
            ch.NhapCuaHang();
            ch.TinhTongTienBan();
            ch.XuatCuaHang();
            Console.ReadKey();

        }
    }

}