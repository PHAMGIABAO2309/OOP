using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vidu_Overload_toantu
{// dinh nghia phep cong 2 phan so
    class Phanso
    {
        Int32 tu, mau;
        //thêm phương thức Constructor cho PHanso
        public Phanso()
        {
            tu = 0;
            mau = 1;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            tu = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap mau so: ");
            mau = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.Write("{0}/{1}", tu, mau);
        }
        public void ToiGian()
        {
            Int32 u;
            if (tu < mau)
                u = tu;
            else
                u = mau;
            while (((tu % u) != 0 || (mau % u) != 0))
                u = u - 1;
            tu = tu / u;
            mau = mau / u;
        }
        public static Phanso operator +(Phanso a, Phanso b)
        {
            Phanso c = new Phanso();
            c.tu = (a.tu * b.mau) + (b.tu * a.mau);
            c.mau = a.mau * b.mau;
            return c;
        }
        static void Main(string[] args)
        {
            Phanso a = new Phanso();
            Phanso b = new Phanso();
            Phanso c = new Phanso();
            Console.WriteLine("Nhap phan so thu nhat: ");
            a.Nhap();
            Console.WriteLine("\n Nhap phan so thu hai: ");
            b.Nhap();
            c = a + b;
            c.ToiGian();
            Console.Write("\n Ket qua tong cua 2 phan so: ");
            c.Xuat();
            Console.ReadKey();
        }
    }
    //them lop so phuc
    class Sophuc
    {
        Int32 thuc, ao;
        // thêm Constructor cho Sophuc
        public Sophuc()
        {
            thuc = 0;
            ao = 0;
        }

        public void Nhap()
        {
            Console.Write("Nhap phan thuc= ");
            thuc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap phan ao= ");
            ao = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("phan thuc= {0};phan ao= {1}", thuc, ao);
        }
        public static Sophuc operator +(Sophuc a, Sophuc b)
        {
            Sophuc c = new Sophuc();
            c.thuc = a.thuc + b.thuc;
            c.ao = a.ao + b.ao;
            return c;
        }
        static void Main(string[] args)
        {
            Sophuc a = new Sophuc();
            Sophuc b = new Sophuc();
            Sophuc c = new Sophuc();
            Console.WriteLine("Nhap so phuc thu nhat: ");
            a.Nhap();
            Console.WriteLine("\n Nhap so phuc thu hai: ");
            b.Nhap();
            c = a + b;
            Console.Write("\n Ket qua tong cua 2 so phuc: ");
            c.Xuat();
            Console.ReadKey();
        }
    }
}