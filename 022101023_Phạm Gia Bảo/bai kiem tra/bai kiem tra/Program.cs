using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022101032
{
    class Program
    {

        class MONHOC
        {
            public string MaMH { get; set; }
            public string TenMH { get; set; }
            public int SoTinChi { get; set; }
            public int SoTietThucHanh { get; set; }
            public int SoTietBaiTap { get; set; }


            public static bool operator ==(MONHOC mh1, MONHOC mh2)
            {
                return mh1.MaMH == mh2.MaMH;
            }

            public static bool operator !=(MONHOC mh1, MONHOC mh2)
            {
                return !(mh1 == mh2);
            }
        }

        class LOP
        {
            public string MaLop { get; set; }
            public string TenLop { get; set; }
            public string TenNganh { get; set; }

        }

        class SINHVIEN
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public string GioiTinh { get; set; }
            public DateTime NgaySinh { get; set; }
            public LOP Lop { get; set; }
        }

        class DIEMTHI
        {
            public SINHVIEN SinhVien { get; set; }
            public MONHOC MonHoc { get; set; }
            public int HocKy { get; set; }
            public int NamHoc { get; set; }
            public double DiemQuaTrinh { get; set; }
            public double DiemCuoiKy { get; set; }
            public double DiemTBMon { get; set; }

            public double TinhTB()
            {
                return (DiemQuaTrinh + DiemCuoiKy) / 2;
            }
        }



        static void Main(string[] args)
        {
            List<LOP> dsLop = new List<LOP>
            {
                new LOP { MaLop = "CNTT22A", TenLop = "Cong nghe thong tin 22a", TenNganh = "Cong nghe thong tin"},
                new LOP { MaLop = "CNTT22B", TenLop = "Cong nghe thong tin 22b", TenNganh = "Cong nghe thong tin"},
                new LOP { MaLop = "CNTT22C", TenLop = "Cong nghe thong tin 22c", TenNganh = "Cong nghe thong tin"}
            };

            List<MONHOC> dsMonHoc = new List<MONHOC>
            {
                new MONHOC { MaMH = "KTLT", TenMH = "Ky thuat lap trinh", SoTinChi = 3, SoTietThucHanh = 30, SoTietBaiTap = 40 },
                new MONHOC {MaMH = "CSDL", TenMH = "Co so du lieu", SoTinChi = 4, SoTietThucHanh  = 50, SoTietBaiTap = 50 },
                new MONHOC {MaMH = "LTHDT", TenMH = "Lap trinh huong doi tuong", SoTinChi = 3, SoTietThucHanh  = 60, SoTietBaiTap = 30 }
            };

            List<SINHVIEN> dsSinhVien = new List<SINHVIEN>
            {
                new SINHVIEN {MaSV = "022101032", HoTen = "Huynh Thanh Sang", GioiTinh = "Nam", NgaySinh = new DateTime(2004,12,1), Lop = dsLop[0]},
                new SINHVIEN {MaSV = "022101033", HoTen = "Huynh Long Phi", GioiTinh = "Nam", NgaySinh = new DateTime(2004,1,12), Lop = dsLop[1] },
                new SINHVIEN {MaSV = "022101034", HoTen = "Pham Gia Bao", GioiTinh = "Nam", NgaySinh = new DateTime(2004,7,7), Lop = dsLop[2] }
            };

            List<DIEMTHI> dsDiemThi = new List<DIEMTHI>
            {
                new DIEMTHI { SinhVien = dsSinhVien[0], MonHoc = dsMonHoc[0], HocKy = 1, NamHoc = 2023, DiemQuaTrinh = 9, DiemCuoiKy = 8 },
                new DIEMTHI { SinhVien = dsSinhVien[0], MonHoc = dsMonHoc[1], HocKy = 1, NamHoc = 2021, DiemQuaTrinh = 7, DiemCuoiKy = 9 },
                new DIEMTHI { SinhVien = dsSinhVien[0], MonHoc = dsMonHoc[2], HocKy = 1, NamHoc = 2020, DiemQuaTrinh = 9, DiemCuoiKy = 10 },

                new DIEMTHI { SinhVien = dsSinhVien[1], MonHoc = dsMonHoc[0], HocKy = 1, NamHoc = 2023, DiemQuaTrinh = 9, DiemCuoiKy = 8 },
                new DIEMTHI { SinhVien = dsSinhVien[1], MonHoc = dsMonHoc[1], HocKy = 1, NamHoc = 2021, DiemQuaTrinh = 7, DiemCuoiKy = 7},
                new DIEMTHI { SinhVien = dsSinhVien[1], MonHoc = dsMonHoc[2], HocKy = 1, NamHoc = 2020, DiemQuaTrinh = 6, DiemCuoiKy = 10 },

                new DIEMTHI { SinhVien = dsSinhVien[2], MonHoc = dsMonHoc[0], HocKy = 1, NamHoc = 2023, DiemQuaTrinh = 9, DiemCuoiKy = 8 },
                new DIEMTHI { SinhVien = dsSinhVien[2], MonHoc = dsMonHoc[1], HocKy = 1, NamHoc = 2021, DiemQuaTrinh = 7, DiemCuoiKy = 9},
                new DIEMTHI { SinhVien = dsSinhVien[2], MonHoc = dsMonHoc[2], HocKy = 1, NamHoc = 2020, DiemQuaTrinh = 9, DiemCuoiKy = 10 }

            };


            // In danh sách điểm thi
            Console.WriteLine("Danh sach diem thi:");
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10} {5,-10}", "MaSV", "HoTen", "MaMH", "HocKy", "DiemQuaTrinh", "DiemCuoiKy");

            foreach (DIEMTHI dt in dsDiemThi)
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-13} {5,-10}", dt.SinhVien.MaSV, dt.SinhVien.HoTen, dt.MonHoc.MaMH, dt.HocKy, dt.DiemQuaTrinh, dt.DiemCuoiKy);
            }

            Console.WriteLine();

            // In kết quả của từng sinh viên
            Console.WriteLine("Ket qua cua tung sinh vien:");
            foreach (SINHVIEN sv in dsSinhVien)
            {
                Console.WriteLine("Thong tin diem thi cua sinh vien {0} - {1}:", sv.MaSV, sv.HoTen);

                var diemSinhVien = dsDiemThi.Where(dt => dt.SinhVien == sv).ToList();

                foreach (DIEMTHI dt in diemSinhVien)
                {
                    Console.WriteLine("{0}_____{1}_____ {2}_____ {3}_____ {4}____{5}", dt.MonHoc.MaMH, dt.MonHoc.TenMH, dt.HocKy, dt.DiemQuaTrinh, dt.DiemCuoiKy,dt.TinhTB());
                }

                Console.WriteLine(); // Xuống dòng giữa các sinh viên
            }

            Console.WriteLine();

            // In kết quả thi của từng môn
            Console.WriteLine("Ket qua thi cua tung mon:");
            foreach (MONHOC mh in dsMonHoc)
            {
                Console.WriteLine("Thong tin diem thi cua mon hoc {0} - {1}:", mh.MaMH, mh.TenMH);

                var diemMonHoc = dsDiemThi.Where(dt => dt.MonHoc == mh).ToList();

                foreach (DIEMTHI dt in diemMonHoc)
                {
                    Console.WriteLine(" {0,-10} {1,-20} {2,-13} {3,-10}", dt.SinhVien.MaSV, dt.SinhVien.HoTen, dt.DiemQuaTrinh, dt.DiemCuoiKy);
                }

                Console.WriteLine(); // Xuống dòng giữa các môn
            }

            Console.ReadKey();

            Console.ReadKey();

        }
    }
}