using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace c2b4
{
    class lophoc
    {
        public string malop;
        public string getmalop()
        {
            return malop;
        }
        private string tenlop;
        public string gettenlop()
        {
            return tenlop;
        }
        public lophoc()
        {
            Console.WriteLine("Nhap ma lop: ");
            malop = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ten lop: ");
            tenlop = Convert.ToString(Console.ReadLine());
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
    class hocphan
    {
        public string mahp;
        private string tenhp;
        private string sotinchi;
        public hocphan()
        {
            Console.WriteLine("Nhap ma hoc phan: ");
            mahp = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ten hoc phan: ");
            tenhp = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap so tin chi: ");
            sotinchi = Convert.ToString(Console.ReadLine());
        }
        public string getmahp()
        {
            return mahp;
        }
        public string gettenhp()
        {
            return tenhp;
        }
        public string getsotinchi()
        {
            return sotinchi;
        }
    }
    class ketquathi
    {
        public string masosv;
        public string mahp;
        private string hocky;
        private string namhoc;
        private string diemlan1;
        private string diemlan2;
        public ketquathi()
        {
            Console.WriteLine("Nhap ma so sv: ");
            masosv = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ma hoc phan: ");
            mahp = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap hoc ky: ");
            hocky = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap nam hoc: ");
            namhoc = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap diem lan 1: ");
            diemlan1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap diem lan 2: ");
            diemlan2 = Convert.ToString(Console.ReadLine());
        }
        public string getmasosv()
        {
            return masosv;
        }
        public string getmahp()
        {
            return mahp;
        }
        public string gethocky()
        {
            return hocky;
        }
        public string getnamhoc()
        {
            return namhoc;
        }
        public string getdiemlan1()
        {
            return diemlan1;
        }
        public string getdiemlan2()
        {
            return diemlan2;
        }

    }
        class program
        {
        static void Main(string[] args)
        {
            // Khai bao 1 bien mang cua Lop Hoc
                lophoc[] dslop = new lophoc[2];
                for (int i = 1; i <= dslop.Length; i++)
                {
                    Console.WriteLine("Nhap lop thu {0}", i);
                    dslop[i] = new lophoc();
                }
                for (int i = 1; i <= dslop.Length; i++)
                {
                    Console.WriteLine("{0}.{1} - {2} ", i, dslop[i].malop, dslop[i].gettenlop());
                }
                //khai bao 1 bien danh sach cua Sinh Vien
                List<sinhvien> dssv = new List<sinhvien>();
                Console.WriteLine("\n *************Nhap danh sach sinh vien");
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Nhap thong tin sinh vien thu {0}", j);
                    dssv.Add(new sinhvien());
                }
                Console.WriteLine("\n ************danh sach sinh vien da nhap");
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("\n {0}.{1} - {2} - {3} - {4} - {5} ", j, dssv[j].masosv, dssv[j].gethotensv(), dssv[j].getgioitinhsv(), dssv[j].getngaysinhsv(), dssv[j].malop);
                }
            //khai bao 1 bien mang cua Hoc Phan
            List<hocphan> dshp = new List<hocphan>();
            Console.WriteLine("\n ********Nhap vao cac hoc phan");
            for (int k = 1; k <= 3; k++)
            {
                Console.WriteLine("Nhap vao cac hoc phan thu {0}",k);
                dshp.Add(new hocphan());
                
            }
            for (int k = 1; k <= 3; k++)
            {
                Console.WriteLine("\n {0} - {1} - {2} - {3} ", k, dshp[k].mahp, dshp[k].gettenhp(), dshp[k].getsotinchi());
            }
            //Khai bao 1 bien mang cua Ket Qua Thi
            List<ketquathi> dskq = new List<ketquathi>();
            Console.WriteLine("\n ******Nhap vao ket qua thi");
            for(int h = 1; h <=6;h++)
            {
                Console.WriteLine("Nhap vao ket qua thi thu {0}", h);
                dskq.Add(new ketquathi());
            }
            for(int h = 1;h<=6;h++)
            {
                Console.WriteLine("\n{0} - {1} - {2} -{3} - {4} - {5} - {6}", h, dskq[h].masosv, dskq[h].getmahp(), dskq[h].gethocky(), dskq[h].getnamhoc(), dskq[h].getdiemlan1(), dskq[h].getdiemlan2());
            }
            //in ra danh sach Ket Qua Thi cua tung Lop Hoc
            List<ketquathi> kqlophoc = new List<ketquathi>();
            for(int e = 0; e < kqlophoc.GetLength(0);e++)
            {
                string lophoc = kqlophoc[e, 0];
                string mahp = kqlophoc[e, 1];
                string ketqua = kqlophoc[e, 2];
                Console.WriteLine("{0} - {1} - {2}", lophoc, mahp, ketqua);
            }
            Console.ReadKey();

        }
        
        }
        
}