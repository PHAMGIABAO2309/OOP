using System;
namespace bai_22
{
    class Employee
    {
        private string HoTen1;
        public string HoTen
        {
            get { return HoTen1; }
            set { HoTen1 = value; }
        }

        private string ID1;
        public string ID
        {
            get { return ID1; }
            set { ID1 = value; }
        }
        public void NhapThongTin()
        {
            Console.WriteLine("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap Chung Minh Nhan Dan: ");
            ID = Console.ReadLine();
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Ho Ten la: " + HoTen);
            Console.WriteLine("So Chung Minh Nhan Dan la: " + ID);
        }
    }
    class bai22
    {
        static void Main(String[] args)
        {
            Employee b22 = new Employee();
            b22.NhapThongTin();
            Console.WriteLine("Thong tin nhan vien la: ");
            b22.XuatThongTin();
            Console.ReadKey();
        }
    }
}