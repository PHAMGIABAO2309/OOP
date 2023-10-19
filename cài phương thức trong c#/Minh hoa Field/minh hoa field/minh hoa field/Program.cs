using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace field
{
    class class1
    {
        //khai bao 2 field
        public int i;
        public int j;
        //khai bao phuong thuoc
        public int Tong()
        {
            return i + j;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap so thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            //khai bao va khoi tao doi tuong
            class1 cls = new class1();
            //gan gia tri cho field
            cls.i = a;
            cls.j = b;
            //lay gia tri cua field
            Console.WriteLine("Tong cua {0} va {1} la {2} ", cls.i, cls.j, cls.Tong());
            Console.ReadLine();
        }
    }
}