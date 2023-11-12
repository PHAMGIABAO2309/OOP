
using System;

namespace bai_16
{
    class bai16
    {
        int n;
        int[] arr;

        public bai16()
        {
            Console.WriteLine("nhap n : ");
            n = int.Parse(Console.ReadLine());

            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        private bool KiemTraSoNguyenTo(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public void TongSoNguyenTo()
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (KiemTraSoNguyenTo(arr[i]))
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine("Tong cac so nguyen to la: " + sum);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bai16 b16 = new bai16();
            b16.TongSoNguyenTo();

            Console.ReadKey(true);
        }
    }
}

