using System;
namespace DAHINH
{
    class HINH
    {
        public virtual void Nhap()
        { }
        public virtual void Dientich()
        { }
    }
    class HINHTRON : HINH
    {
        const double PI = 3.1416;
        double R;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ban kinh hinh tron: ");
            R = Convert.ToDouble(Console.ReadLine());
        }
        public override void Dientich()
        {
            base.Dientich();
            Console.WriteLine("Dien tich hinh tron ban kinh [{0}] la: {1}", R, PI * R * R);
        }
    }
    class HINHCHUNHAT : HINH
    {
        int d, r;
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap chieu dai: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            r = Convert.ToInt32(Console.ReadLine());
        }
        public override void Dientich()
        {
            base.Dientich();
            Console.WriteLine("Dien tich hinh chu nhat ( {0}, {1} ) la: {2} ", d, r, d * r);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            HINH[] h = new HINH[100];
            int n, chon;
            Console.WriteLine("Nhap so luong hinh: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                Console.Write("Can tinh hinh TRON (0) - CHUNHAT(1): ");
                chon = Convert.ToInt32(Console.ReadLine());
                if ( chon == 0 )
                {
                    HINHTRON ht = new HINHTRON();
                    h[i] = ht;
                }
                else
                {
                    HINHCHUNHAT hcn = new HINHCHUNHAT();
                    h[i] = hcn;
                }
                h[i].Nhap();
            }
            for(int i = 0; i<n; i++)
            {
                h[i].Dientich();
            }
        }
    }
}