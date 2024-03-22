using System;

namespace qlgv
{
    class ThongTin
    {
        private int magv;
        private string gioitinh, hoten, sodt, email, hocvi, hocham, chuyenmon;
        private DateTime ngaysinh;

        public virtual void Nhap()
        {
            Console.Write("Nhap ma giao vien: ");
            magv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap ngaysinh: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            gioitinh = Console.ReadLine();
            Console.Write("Nhap sodt: ");
            sodt = Console.ReadLine();
            Console.Write("Nhap email: ");
            email = Console.ReadLine();
            Console.Write("Nhap hoc vi: ");
            hocvi = Console.ReadLine();
            Console.Write("Nhap hoc ham: ");
            hocham = Console.ReadLine();
            Console.Write("Nhap chuyen mon: ");
            chuyenmon = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15} {7,-15} {8,-15}", magv, hoten, ngaysinh, gioitinh, sodt, email, hocvi, hocham, chuyenmon);
        }

        public static bool operator ==(ThongTin gv1, ThongTin gv2)
        {
            return (gv1.magv == gv2.magv);
        }

        public static bool operator !=(ThongTin gv1, ThongTin gv2)
        {
            return (gv1.magv != gv2.magv);
        }
    }

    class GVcohuu : ThongTin
    {
        private int machucdanh, hesoluong;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ma chuc danh: ");
            machucdanh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so luong: ");
            hesoluong = Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("{0,-15} {1,-15}", machucdanh, hesoluong);
        }
    }

    class GVthinhgiang : ThongTin
    {
        private int donvicongtac;
        private DateTime ngaythamgia;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap don vi cong tac: ");
            donvicongtac = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ngay tham gia: ");
            ngaythamgia = Convert.ToDateTime(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("{0,-15} {1,-15}", donvicongtac, ngaythamgia);
        }
    }

    class DSGV
    {
        ThongTin[] L;

        public void NhapThongTin()
        {
            int n;
            Console.Write("Nhap so luong giang vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            L = new ThongTin[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap loai giang vien ({i + 1}/{n}): (1 - Co huu, 2 - Thinh giang): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                    L[i] = new GVcohuu();
                else if (choice == 2)
                    L[i] = new GVthinhgiang();
                else
                    Console.WriteLine("Lua chon khong hop le.");

                L[i].Nhap();
            }
        }

        public void XuatThongTin()
        {
            int n = L.Length;

            for (int i = 0; i < n; i++)
            {
                L[i].Xuat();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DSGV ds = new DSGV();
            ds.NhapThongTin();
            ds.XuatThongTin();
        }
    }
}
