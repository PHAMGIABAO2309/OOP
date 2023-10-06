﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ViduAnonymous
{
    class Program
    {
        delegate int DelegateTong(int i, int j);
        static void Main(string[] args)
        {
            int a = 10, b = 40;
            DelegateTong delTong = delegate (int i, int j)
            {
                return i + j;
            };
            Console.WriteLine("Tong cua {0} va {1} la {2} ", a, b, delTong(a, b));
            Console.ReadKey();
        }
    }
}