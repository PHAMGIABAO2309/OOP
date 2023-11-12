using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace bai_21
{
    class bai21
    {
        int x1, x2, x3, y1, y2, y3;
        //double tructam_x, tructam_y;
        public bai21()
        {
            Console.WriteLine("Nhap x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap x3: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap y3: ");
            y3 = Convert.ToInt32(Console.ReadLine());
        }
        public void ToaDoTrongTam()
        {
            double trongtam_x = (x1 + x2 + x3) / 3.0;
            double trongtam_y = (y1 + y2 + y3) / 3.0;
            Console.WriteLine("Toa Do Trong Tam X: " + trongtam_x);
            Console.WriteLine("Toa Do Trong Tam Y: " + trongtam_y);
        }
        public void ToaDoTrucTam()
        {
            double tructam_x = (x1 + x2) / 2.0;
            double tructam_y = (y1 + y2) / 2.0;
            Console.WriteLine("Toa Do Truc Tam X: " + tructam_x);
            Console.WriteLine("Toa Do Truc Tam Y: " + tructam_y);
        }
        public void ToaDoTamVongTrongNgoaiTiep()
        {
            double tructam_x = (x1 + x2) / 2.0;
            double tructam_y = (y1 + y2) / 2.0;
            double tamngoaitiep_x = (tructam_x + x3) / 2.0;
            double tamngoaitiep_y = (tructam_y + y3) / 2.0;
            Console.WriteLine("Toa do Tam Vong Tron Ngoai Tiep X: " + tamngoaitiep_x);
            Console.WriteLine("Toa do Tam Vong Tron Ngoai Tiep Y: " + tamngoaitiep_y);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            bai21 b21 = new bai21();
            b21.ToaDoTrongTam();
            b21.ToaDoTrucTam();
            b21.ToaDoTamVongTrongNgoaiTiep();
            Console.ReadKey();
        }
    }
}