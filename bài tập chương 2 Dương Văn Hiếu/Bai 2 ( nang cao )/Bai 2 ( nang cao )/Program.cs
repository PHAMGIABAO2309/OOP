using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace c2b2
{
    class sinhvien
    {
        public string masosv;
        public string getmasosv()
        {
            return masosv;
        }
        private string hotensv;
        public string gethotensv()
        {
            return hotensv;
        }
        private string ngaysinhsv;
        public string getngaysinhsv()
        {
            return ngaysinhsv;
        }
        private Byte privategioitinhsv;
        public Byte getgioitinhsv()
        {
            return gioitinhsv;
        }
        public Byte gioitinhsv
        {
            get { return privategioitinhsv; }
            set
            {
                if (value != 0)
                    privategioitinhsv = 1;
                else
                    privategioitinhsv = 0;
            }
        }
        public sinhvien()
        {
            Console.WriteLine("Nhap mssv: ");
            masosv = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ho ten sv: ");
            hotensv = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh sv: ");
            gioitinhsv = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Nhap ngay sinh sv: ");
            ngaysinhsv = Convert.ToString(Console.ReadLine());
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            List<sinhvien> dssv = new List<sinhvien>();
            Console.WriteLine("Nhap danh sach sinh vien:");
            for(int i = 0; i< 3;i++)
            {
                Console.WriteLine("Nhap thong tinh sinh vien thu {0}", i);
                dssv.Add(new sinhvien());
            }
            Console.WriteLine("danh sach sinh vien da nhap");
            for(int i = 0; i<3;i++)
            {
                Console.WriteLine("{0}.{1} - {2} - {3} - {4}", i, dssv[i].masosv, dssv[i].gethotensv(), dssv[i].getgioitinhsv(), dssv[i].getngaysinhsv());
            }
            Console.ReadKey();
        }
    }
}