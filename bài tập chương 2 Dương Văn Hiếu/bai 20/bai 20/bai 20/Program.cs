using System;
namespace bai20
{
    class Person
    {
        string hoten;
        string ngaysinh;
        Decimal[] diem9mon;
        string kq;
        public Person()
        {
            Console.WriteLine("Nhap Ho va Ten: ");
            hoten = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap Ngay Thang Nam Sinh: ");
            ngaysinh = Convert.ToString(Console.ReadLine());
        }
        public void Nhap()
        {
            diem9mon = new Decimal[9];
            for(int i=0; i<9; i++)
            {
                Console.WriteLine("Nhap diem mon thu [ {0} ]: ", i + 1);
                diem9mon[i] = Convert.ToDecimal(Console.ReadLine());
            }
        }
        public void XetKetQua()
        {
            Decimal dtb = 0;
            int i, thilai = 0;
            for( i=0; i<9; i++)
            {
                dtb = dtb + diem9mon[i];
            }
            dtb = dtb / 9;
             i = 0;
            while ((i < 9) && (thilai == 0))
            {
                if (diem9mon[i] < 5)
                {
                    thilai = 1;
                }
                else
                    i++;
            }
            if(thilai == 1)
            {
                kq = "Thi lai";
            }
            else if ( dtb > 7)
            {
                kq = "Lam luan van";
            }
            else
            {
                kq = "Thi tot nghiep";
            }
        }
        public void InKetQua()
        {
            string S = " ";
            S = kq;
            if( kq == "Thi lai ")
            {
                S += " Cac mon sau: ";
            }
            for(int i=0; i<9; i++)
            {
                if (diem9mon[i] < 5)
                {
                    S = S + (i + 1).ToString() + " , ";
                }
            }
            Console.WriteLine(" {0} - {1} - {2} ",hoten,ngaysinh, S);
        }
    }
    class dshv
    {
        Person[] DS;
        public void NhapDS()
        {
            int n;
            Console.WriteLine("Nhap so luong sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new Person[n];
            for(int i=0; i<n; i++)
            {
                DS[i] = new Person();
                DS[i].Nhap();
                DS[i].XetKetQua();
                DS[i].InKetQua();
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            dshv b20 = new dshv();
            b20.NhapDS();
        }
    }
}