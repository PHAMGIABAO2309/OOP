using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai1
{
    class NHANVIEN
    {
        string hoten;
        string ngaysinh;
        string diachi;
        public virtual void Nhap()
        {
            Console.Write("\n Nhap ho va ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            ngaysinh = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.Write(" {0} -  {1}  -  {2} ", hoten, ngaysinh, diachi);
        }
    }
    class NVSANXUAT : NHANVIEN
    {
        int sosanpham;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so san pham: ");
            sosanpham = Convert.ToInt32(Console.ReadLine());
            
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine(" - {0}d ", sosanpham * 2000);
        }
    }
    class NVQUANLY : NHANVIEN
    {
        int luongcoban;
        int hesoluong;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong co ban: ");
            luongcoban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so: ");
            hesoluong = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine(" - {0} ", luongcoban * hesoluong);
        }
    }
    class DSNVSX
    {
        NVSANXUAT[] DS;
        public void NhapDS()
        {
            int n;
            Console.WriteLine("Nhap so luong nhan vien san xuat: ");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new NVSANXUAT[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n Nhap nhan vien bien che thu {0} :", i + 1);
                DS[i] = new NVSANXUAT();
                DS[i].Nhap();
            }
            Console.WriteLine("\n Thong tin nhan vien san xuat vua nhap: ");
            for (int i=0; i<n; i++)
            {

                DS[i].Xuat();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DSNVSX ds1 = new DSNVSX();
            
            ds1.NhapDS();
            
        }
    }
}