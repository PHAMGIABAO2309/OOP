using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace c2_bai3_nangcao
{
    class lophoc
    {
        public string malop;
        private string tenlop;
        public lophoc()
        {
            Console.Write("Nhap ma lop: ");
            malop = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ten lop: ");
            tenlop = Convert.ToString(Console.ReadLine());
        }
        public string getmalop()
        {
            return malop;
        }
        public string gettenlop()
        {
            return tenlop;
        }
        
    }
    class sinhvien
    {
        public string malop;
        public string getmalop()
        {
            return malop;
        }
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
        private Byte gioitinhsv
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
            Console.WriteLine("Nhap ma so sv: ");
            masosv = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ho ten sv: ");
            hotensv = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ngay sinH sv: ");
            ngaysinhsv = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh sv: ");
            gioitinhsv = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Nhap ma lop: ");
            malop = Convert.ToString(Console.ReadLine());
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            lophoc[] dslop = new lophoc[2];
            for(int i = 0; i < dslop.Length;i++)
            {
                Console.WriteLine("*********Nhap lop thu {0}", i);
                dslop[i] = new lophoc();
            }
            Console.WriteLine("\n *****************danh sach lop da nhap");
            for(int i = 0; i < dslop.Length; i++)
            {
                Console.WriteLine("{0}.{1} - {2} ", i, dslop[i].malop, dslop[i].gettenlop());
            }
            List<sinhvien> dssv = new List<sinhvien>();
            Console.WriteLine("\n *************Nhap danh sach sinh vien");
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine("\n Nhap thong tin sinh vien thu {0}", j);
                dssv.Add(new sinhvien());
            }
            Console.WriteLine("\n ************danh sach sinh vien da nhap");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("\n {0}.{1} - {2} - {3} - {4} - {5} ", j, dssv[j].masosv, dssv[j].gethotensv(), dssv[j].getgioitinhsv(), dssv[j].getngaysinhsv(), dssv[j].malop);
            }
            List<sinhvien> dskhac = new List<sinhvien>();
            foreach( sinhvien sv in dssv)
            {
                bool thuoclop = false;

                foreach(lophoc lop in dslop)
                {
                    if (sv.getmalop() == lop.malop)
                    {
                        thuoclop = true;
                        break;
                    }
                }
                if(!thuoclop)
                {
                    dskhac.Add(sv);
                }
                Console.WriteLine(" Danh sach nhung sinh vien khong thuoc vao danh sach da nhap");
                for(int k = 0; k < dskhac.Count; k++)
                {
                    Console.WriteLine("{0}", dskhac[k].gethotensv());
                }
            }
            Console.ReadKey();
        }
    }
}