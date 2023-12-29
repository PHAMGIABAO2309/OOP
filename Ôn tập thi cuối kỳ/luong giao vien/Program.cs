using System;
namespace luong
{
    class ThongTin
    {
        protected string SoCCCD, HoTen, NgaySinh,Email,DiaChi,Sodt;
        protected int GioiTinh; // 1=Nam. 0=Nu
        public virtual void Nhap()
        {
            Console.WriteLine("\n");
            Console.Write("Nhap so CCCD: ");
            SoCCCD = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Ngay sinh: ");
            NgaySinh = Console.ReadLine();
            do
            {
                
            Console.Write("Nhap Gioi Tinh: ");
            GioiTinh = Convert.ToInt32(Console.ReadLine());
            } while ( !(GioiTinh >=0 && GioiTinh <=1));
            Console.Write("Nhap So Dien Thoai: ");
            Sodt = Console.ReadLine();
            Console.Write("Nhap Email: ");
            Email = Console.ReadLine();
            Console.Write("Nhap Dia Chi: ");
            DiaChi = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("So CCCD: {0,-20} Ho Ten: {1,-20} Ngay Sinh: {2,-20}", SoCCCD, HoTen,NgaySinh);
            Console.WriteLine("Gioi Tinh: ");
            if ( GioiTinh == 1 )
            {
                Console.WriteLine("Nam");
            }
            else if ( GioiTinh == 0 )
            {
                Console.WriteLine("Nu");
            }
            Console.WriteLine("So Dien Thoai: {0,-20} Email: {1,-30} Dia Chi: {2,-30}",Sodt,Email,DiaChi); 
        }
    }
    class GiangVien : ThongTin
    {
        float hesoluong;
        int luongcoban = 180000;
        double luonghangthang;

        int DonGia = 95000;
        int sogiovuot;
        int tiendayvuotgio;

        int sonamkinhnghiem;
        double phucapthamnien;
        public override void Nhap()
        {
            
            base.Nhap();
            Console.Write("Nhap He So Luong: ");
            hesoluong = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap So Gio Vuot: ");
            sogiovuot = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap So Nam Kinh Nghiem: ");
            sonamkinhnghiem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            luonghangthang = hesoluong * luongcoban;
            tiendayvuotgio = DonGia * sogiovuot;
            phucapthamnien = sonamkinhnghiem * 0.01 * luonghangthang;
        }
        public override void Xuat()
        {
            Console.WriteLine(" ============================================= Thong Tin Giao Vien ========================================================= ");
            base.Xuat();
            Console.WriteLine(" Luong Hang Thang: {0,-15} Tien Day Vuot Gio: {1,-15} Phu Cap Tham Nien: {2,-15}",luonghangthang,tiendayvuotgio,phucapthamnien);
        }
        public double Tinhluonghangthang()
        {
            return luonghangthang;
        }
    }
    class VienChuc : ThongTin
    {
        int hesoluong;
        int luongcoban = 1800000;
        double luonghangthang;

        int DonGia = 30000;
        int sogio;
        double tienluonglamthemgio;

        int sothang;
        int phucap = 340000;
        double phucaphanhchinh;

        public override void Nhap()
        {
            
            base.Nhap();
            Console.Write("Nhap He So Luong: ");
            hesoluong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap So Gio: ");
            sogio = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Nhap So Thang: ");
                sothang = Convert.ToInt32(Console.ReadLine());
            } while ( !(sothang >= 1 && sothang <= 12 ) );
            Console.WriteLine("\n");
            luonghangthang = hesoluong * luongcoban;
            tienluonglamthemgio = DonGia * sogio;
            phucaphanhchinh = phucap * sothang; 
        }
        public override void Xuat()
        {
            Console.WriteLine(" ================================================= Thong Tin Vien Chuc ============================================================== ");
            base.Xuat();
            Console.WriteLine(" Luong Hang Thang: {0,-15} Tien luong lam them gio: {1,-15} Phu cap hanh chinh: {2,-15}",luonghangthang,tienluonglamthemgio,phucaphanhchinh);
        }
        public double Tinhluonghangthang()
        {
            return luonghangthang;
        }
    }
    class NguoiLaoDong : ThongTin
    {
        int luong = 4500000;
        int sothang;
        double luongtheohopdong;

        int DonGia = 30000;
        int sogio;
        double tienluonglamthemgio;
        public override void Nhap()
        {
            base.Nhap();
            do
            {
                Console.Write("Nhap So Thang: ");
                sothang = Convert.ToInt32(Console.ReadLine());
            } while ( !(sothang >= 1 && sothang <= 12 ) );
            Console.Write("Nhap So Gio: ");
            sogio = Convert.ToInt32(Console.ReadLine());

            luongtheohopdong = luong * sothang;
            tienluonglamthemgio = DonGia * sogio;
            Console.WriteLine("\n");
        }
        public override void Xuat()
        {
            Console.WriteLine(" ================================================= Thong Tin Nguoi Lao Dong ============================================================== ");
            base.Xuat();
            Console.WriteLine("Luong Theo Hop Dong: {0,-4} Luong Lam Them Gio: {1}",luongtheohopdong,tienluonglamthemgio);
        }
        public double Tinhluongtheohopdong()
        {
            return luongtheohopdong;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GiangVien gv = new GiangVien();
            gv.Nhap();
            gv.Xuat();
            VienChuc vc = new VienChuc();
            vc.Nhap();
            vc.Xuat();
            NguoiLaoDong nld = new NguoiLaoDong();
            nld.Nhap();
            nld.Xuat();

            double tongLuongHangThang = gv.Tinhluonghangthang() + vc.Tinhluonghangthang() + nld.Tinhluongtheohopdong();
            double tongLuongHangNam = tongLuongHangThang * 12;
            Console.WriteLine("\n Tong luong hang thang cua tat ca nguoi lam viec: {0}",tongLuongHangThang);
            Console.WriteLine("Tong luong Hang Nam cua tat ca nguoi lam viec: {0}",tongLuongHangNam);
            Console.ReadKey();
        }
    }
}