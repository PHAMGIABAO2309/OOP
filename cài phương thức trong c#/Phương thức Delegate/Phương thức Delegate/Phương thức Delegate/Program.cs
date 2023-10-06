using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Delegate là một đối tượng gắn liền với 1 phương thức
// Mỗi kho Delegate được gọi thì phương thức gắn liền với nó được thực thi
namespace viduDelegate
{
    // tao 2 delegate
    delegate void NhapDelegate();
    delegate int TinhChuViDelegate();
    class HinhChuNhat
    {
        Int32 a, b;
        public void Nhap()
        {
            Console.Write("Nhap chieu dai hinh chu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public int ChuVi()
        {
            return (a + b) * 2;
        }
    }
    class HinhVuong
    {
        Int32 a;
        public void Nhap()
        {
            Console.Write("Nhap canh hinh vuong: ");
            a = Convert.ToInt32(Console.ReadLine());
        }
        public int ChuVi()
        {
            return a * 4;
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            HinhVuong hv = new HinhVuong();
            NhapDelegate delnhap1 = new NhapDelegate(hcn.Nhap);
            delnhap1();
            TinhChuViDelegate deltinh1 = new TinhChuViDelegate(hcn.ChuVi);
            Console.WriteLine("Chu Vi Hinh Chu Nhat: {0} ", deltinh1());
            NhapDelegate delnhap2 = new NhapDelegate(hv.Nhap);
            delnhap2();
            TinhChuViDelegate deltinh2 = new TinhChuViDelegate(hv.ChuVi);
            Console.WriteLine("Chu Vi Hinh Vuong: {0} ", deltinh2());
            Console.ReadKey();
        }
    }
}
