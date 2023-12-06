using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai2KeThua
{
    class Mang
    {
        protected int[] mang;
        protected int n;
        public Mang()
        {
            Console.WriteLine("Nhap n:");
            n = Convert.ToInt32(Console.ReadLine());
            mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap pt thu " + i);
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    class Tang : Mang
    {
        protected int[] mang1;
        public Tang()
        {
            mang1 = new int[n];
            for (int i = 0; i < n; i++)
                mang1[i] = mang[i];
            Array.Sort(mang1);
            Console.WriteLine("Mang tang dan la:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang1[i] + " ");
            }
            Console.WriteLine();
        }
    }
    class Giam : Tang
    {
        protected int[] mang2;
        public Giam()
        {
            mang2 = new int[n];
            for (int i = 0; i < n; i++)
                mang2[i] = mang1[i];
            Array.Reverse(mang2);
            Console.WriteLine("Mang giam dan la:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang2[i] + " ");
            }
            Console.WriteLine();
        }
    }
    class TriTuyetDoiTang : Giam
    {
        protected int[] mang3;
        public TriTuyetDoiTang()
        {
            mang3 = new int[n];
            for(int i=0; i<n; i++)
                mang3[i] = mang2[i];
            for (int i = 0; i < n; i++)
                mang3[i] = Math.Abs(mang3[i]);
            Array.Sort(mang3);
            Console.WriteLine("Mang tri tuyet doi tang dan la: ");
            for(int i=0; i<n; i++)
            {
                Console.Write(mang3[i] + " ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TriTuyetDoiTang giam = new TriTuyetDoiTang();
            Console.ReadLine();
        }
    }
}