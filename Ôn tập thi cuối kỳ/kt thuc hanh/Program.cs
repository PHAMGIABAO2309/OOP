
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTTH_DA
{
    //Cài đặt class môn học: 2 điểm
    class MonHoc
    {
        string MaMH, TenMH;
        int SoTC, SoTLT, SoTTH, SoTBT;
        //Cài đặt hàm khởi tạo môn học có tham số
        public void KhoiTao(string mam, string tenm, int tc, int lt, int th, int bt)
        {
            MaMH = mam;
            TenMH = tenm;
            SoTC = tc;
            SoTLT = lt;
            SoTTH = th;
            SoTBT = bt;
        }
        //Cài đặt hàm in 1 môn học
        public void InMonHoc()
        {
            Console.WriteLine("{0}_{1}_{2}_{3}_{4}_{5}", MaMH, TenMH, SoTC, SoTLT, SoTTH, SoTBT);
        }
        //Lấy mã môn học
        public string LayMaMon()
        {
            return MaMH;
        }
        //Lất tên môn học
        public string LayTenMon()
        {
            return TenMH;
        }
        //Cài đặt hàm so sánh 2 môn học dự vào mã môn
        public static int operator ==(MonHoc M1, MonHoc M2)
        {
            if (M1.MaMH == M2.MaMH) // 2 Môn học giống nhau thì có cùng mã môn
                return 1;
            else
                return 0;
        }
        public static int operator !=(MonHoc M1, MonHoc M2)
        {
            if (M1.MaMH != M2.MaMH) // 2 Môn học khác nhau thì khác mã môn
                return 1;
            else
                return 0;
        }

    }
    // Cài đặt class Lớp học: 2 điểm
    class LopHoc
    {
        string MaLop, TenLop, TenNganh;
        //Cài đặt hàm khởi tạo lớp học với tham số vào
        public void KhoiTao(string mal, string tenl, string tenNg)
        {
            MaLop = mal;
            TenLop = tenl;
            TenNganh = tenNg;
        }
        //Cài đặt hàm in lớp học
        public void InLopHoc()
        {
            Console.WriteLine("{0}_{1}_{2}",MaLop, TenLop, TenNganh);
        }
    }
    // Cài đặt class sinh viên: 2 điểm
    class SinhVien
    {
        string MSSV, HoTenSV, MaLop;
        int GioiTinh; //0=nu, 1=nam
        DateTime NgaySinh;
        //Cài đặt hàm khởi tạo SV với tham số
        public void KhoiTao(string ms, string ht, string ml, int gt, DateTime ns)
        {
            MSSV = ms;
            HoTenSV = ht;
            MaLop = ml;
            GioiTinh = gt;
            NgaySinh = ns;
        }
        //Cài đặt hàm in sv
        public void InSinhVien()
        {
            Console.WriteLine("{0}_{1}_{2}_{3}_{4}", MSSV,HoTenSV, MaLop,GioiTinh,NgaySinh);
        }
        public string LayMSSV()
        {
            return MSSV;
        }
        public string LayHoTenSV()
        {
            return HoTenSV;
        }
        //Cài đặt hàm so sánh 2 sinh viên dự vào mã số sv
        public static int operator ==(SinhVien SV1, SinhVien SV2)
        {
            if (SV1.MSSV == SV2.MSSV) // 2 SV giống nhau thì có cùng mã số SV
                return 1;
            else
                return 0;
        }
        public static int operator !=(SinhVien SV1, SinhVien SV2)
        {
            if (SV1.MSSV != SV2.MSSV) // 2 SV khác nhau thì khác mã số SV
                return 1;
            else
                return 0;
        }
    }
    // Cài đặt class điểm thi:2 điểm
    class DiemThi
    {
        string MSSV, MaHM, NamHoc;
        int HocKy;
        double DiemQT, DiemCK, DiemTB;
        //Cài đặt hàm nhập điểm từ bàn phím
        public void Nhap()
        {
            Console.Write("Nhap MSSV = ");
            MSSV = Console.ReadLine();
            Console.Write("Nhap MaMH = ");
            MaHM = Console.ReadLine();
            Console.Write("Nhap NamHoc = ");
            NamHoc = Console.ReadLine();
            Console.Write("Nhap HocKy = ");
            HocKy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap DiemQT = ");
            DiemQT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap DiemCK = ");
            DiemCK = Convert.ToDouble(Console.ReadLine());
            TinhDiemTB();
        }
        //Lấy mã số sv
        public string LayMSSV()
        {
            return MSSV;
        }
        //Lấy mã môn học
        public string LayMaMon()
        {
            return MaHM;
        }
        //Lấy điểm QT
        public double LayDiemQT()
        {
            return DiemQT;
        }
        //Lấy điểm CK
        public double LayDiemCK()
        {
            return DiemCK;
        }
        //Lấy điểm TB
        public double LayDiemTB()
        {
            return DiemTB;
        }
        //Cài đặt hàm in 1 dòng điểm thi
        public void InDiemThi(string tenSV)
        {
            Console.WriteLine("{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}", MSSV, tenSV, MaHM, HocKy, NamHoc, DiemQT, DiemCK, DiemTB);
        }
        //Cài đặt hàm tính điểm trung bình
        void TinhDiemTB()
        {
            DiemTB = (DiemQT+DiemCK) / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)// 2 điểm
        {
            int i,j, dung, SoMH=3,SoLH = 3, SoSV=3, N;
            string hotensv;
            // Khởi tạo mặc định 3 môn học
            MonHoc[] DSMH=new MonHoc[3];
            DSMH[0] = new MonHoc();
            DSMH[0].KhoiTao("Mon1", "Mon học 1", 1, 15, 0, 0);
            DSMH[1] = new MonHoc();
            DSMH[1].KhoiTao("Mon2", "Mon học 2", 2, 15, 30, 0);
            DSMH[2] = new MonHoc();
            DSMH[2].KhoiTao("Mon3", "Mon học 3", 3, 15, 30, 30);

            // Khởi tạo mặc định 3 Lớp học
            LopHoc[] DSLH = new LopHoc[3];
            DSLH[0] = new LopHoc();
            DSLH[0].KhoiTao("Lop1", "Lop học 1", "CNTT");
            DSLH[1] = new LopHoc();
            DSLH[1].KhoiTao("Lop2", "Lop học 2", "CNTT");
            DSLH[2] = new LopHoc();
            DSLH[2].KhoiTao("Lop3", "Lop học 3", "CNTT");

            //Khởi tạo mặc định 3 SV
            // Khởi tạo mặc định 3 Lớp học
            SinhVien[] DSSV = new SinhVien[3];
            DSSV[0] = new SinhVien();
            DSSV[0].KhoiTao("SV1", "Sinh vien 1","Lop1",1,DateTime.Parse("01/01/2000"));
            DSSV[1] = new SinhVien();
            DSSV[1].KhoiTao("SV2", "Sinh vien 2", "Lop1",0, DateTime.Parse("01/01/2000"));
            DSSV[2] = new SinhVien();
            DSSV[2].KhoiTao("SV3", "Sinh vien 3", "Lop2", 1, DateTime.Parse("01/01/2000"));
            //Nhập điểm thi
            Console.Write("Diem thi co bao nhieu dong? ");
            N = Convert.ToInt32(Console.ReadLine());
            DiemThi[] DSDiem = new DiemThi[N];
            for (i=0; i<N;i++)
            {
                Console.WriteLine("Nhap diem thi dong thu {0}:", i);
                DSDiem[i] = new DiemThi();
                DSDiem[i].Nhap();
            }
            //In danh sách điểm thi
            for (i = 0; i < N; i++)
            {
                Console.Write("{0}_",i);
                j = 0; dung = 0; hotensv = "";
                while ((j < SoSV) && (dung == 0))
                    if (DSSV[j].LayMSSV() == DSDiem[i].LayMSSV())
                        dung = 1;
                    else
                        j++;
                DSDiem[i].InDiemThi(DSSV[j].LayHoTenSV());
            }
            //In điểm thi của từng sinh viên
            for (i=0; i<SoSV;i++)
            {
                Console.Write("Sinh viên: ");
                DSSV[i].InSinhVien();
                //In tất cả điểm của sv thứ i
                for (j=0;j<N;j++)
                    if(DSDiem[j].LayMSSV()==DSSV[i].LayMSSV())
                    {
                        string tenmon = "";
                        for (int k = 0; k < SoMH; k++)
                            if (DSMH[k].LayMaMon() == DSDiem[j].LayMaMon())
                                tenmon = DSMH[k].LayTenMon();
                        Console.WriteLine("{0}_{1}_{2}_{3}_{4}", DSDiem[j].LayMaMon(), tenmon, DSDiem[j].LayDiemQT(), DSDiem[j].LayDiemCK(), DSDiem[j].LayDiemTB());
                    }
            }
            //In kết quả thi của từng môn
            for (i = 0; i < SoMH; i++)
            {
                Console.Write("Môn học: ");
                DSMH[i].InMonHoc();
                //In tất cả điểm của môn học thứ i
                for (j = 0; j < N; j++)
                    if (DSDiem[j].LayMaMon() == DSMH[i].LayMaMon())
                    {
                        string tenSV = "";
                        for (int k = 0; k < SoSV; k++)
                            if (DSSV[k].LayMSSV() == DSDiem[j].LayMSSV())
                                tenSV = DSSV[k].LayMSSV();
                        Console.WriteLine("{0}_{1}_{2}_{3}_{4}", DSDiem[j].LayMSSV(), tenSV, DSDiem[j].LayDiemQT(), DSDiem[j].LayDiemCK(), DSDiem[j].LayDiemTB());
                    }
            }
            Console.ReadKey();
        }
    }
}