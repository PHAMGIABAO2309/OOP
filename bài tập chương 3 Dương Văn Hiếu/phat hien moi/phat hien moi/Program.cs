using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace _020101049
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //khai báo nguồn dữ liệu
        dtClsSVDataContext db = new dtClsSVDataContext();
        Table<KHOA> Khoas;
        Table<LOP> Lops;
        private void bthienthi_Click(object sender, EventArgs e)
        {
            //khai báo nguồn dữ liệu
            dtClsSVDataContext db = new dtClsSVDataContext();
            Table<SINHVIEN> Sinh_vien = db.GetTable<SINHVIEN>();
            //tạo truy vấn
            var query = from sv in Sinh_vien
                        where sv.TenSV.StartsWith("T")
                        orderby sv.MaLop
                        select new
                        {
                            sv.MaLop,
                            sv.MaSV,
                            sv.TenSV,
                            sv.NgaySinh,
                            sv.DiaChi
                        };
            //xuất kết quả
            dtghienthi.DataSource = query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //khai báo nguồn dữ liệu
            dtClsSVDataContext db = new dtClsSVDataContext();
            Table<SINHVIEN> Sinhviens = db.GetTable<SINHVIEN>();
            Table<LOP> Lops = db.GetTable<LOP>();
            //tạo truy vấn
            var query = from l in Lops
                        join sv in Sinhviens on l.MaLop equals sv.MaLop
                        where sv.TenSV.StartsWith("T")
                        orderby sv.MaLop
                        select new
                        {
                            sv.MaLop,
                            l.TenLop,
                            sv.MaSV,
                            sv.TenSV,
                            sv.NgaySinh,
                            sv.DiaChi
                        };
            //xuất kết quả
            dtghienthi.DataSource = query;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //khai báo nguồn dữ liệu
            dtClsSVDataContext db = new dtClsSVDataContext();
            Table<SINHVIEN> Sinhviens = db.GetTable<SINHVIEN>();
            Table<LOP> Lops = db.GetTable<LOP>();
            //tạo truy vấn
            var query = from l in Lops
                        join sv in Sinhviens on l.MaLop equals sv.MaLop into qh
                        from q in qh.DefaultIfEmpty()
                        orderby l.MaLop
                        select new
                        {
                            l.MaLop,
                            l.TenLop,
                            masv = (q == null) ? "chưa có" : q.MaSV,
                            tensv = (q == null) ? "chưa có" : q.TenSV,
                            diachi = (q == null) ? "chưa có" : q.DiaChi
                        };
            //xuất kết quả
            dtghienthi.DataSource = query;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //khai báo nguồn dữ liệu
            dtClsSVDataContext db = new dtClsSVDataContext();
            Table<SINHVIEN> Sinhviens = db.GetTable<SINHVIEN>();
            Table<LOP> Lops = db.GetTable<LOP>();
            //tạo truy vấn
            var query = from l in Lops
                        where !(from sv in Sinhviens
                                select
   sv.MaLop).Contains(l.MaLop)
                        select new { l.MaLop, l.TenLop };
            //xuất kết quả
            dtghienthi.DataSource = query;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //khai báo nguồn dữ liệu
            dtClsSVDataContext db = new dtClsSVDataContext();
            Table<SINHVIEN> Sinhviens = db.GetTable<SINHVIEN>();
            Table<LOP> Lops = db.GetTable<LOP>();
            //tạo truy vấn
            var query = from l in Lops
                        join sv in Sinhviens on l.MaLop equals sv.MaLop
                        group sv by new { l.MaLop, l.TenLop } into nh
                        select new { nh.Key.MaLop, nh.Key.TenLop, sosv = nh.Count() };
            dtghienthi.DataSource = query;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Table<SINHVIEN> Sinhviens = db.GetTable<SINHVIEN>();
            Table<LOP> Lops = db.GetTable<LOP>();
            var query = (from l in Lops
                         join sv in Sinhviens on l.MaLop equals sv.MaLop
                         group sv by new { l.MaLop, l.TenLop } into nh
                         orderby nh.Count() descending
                         select new
                         {
                             nh.Key.MaLop,
                             nh.Key.TenLop,
                             SoSVMax =
                         nh.Count()
                         }).Skip(0).Take(1);
            dtghienthi.DataSource = query;
        }
    }


}
