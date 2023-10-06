using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// cho phép người dùng viết mã và thực thi ngay sau đó
// Khai báo trực tiếp ngay bên trong delegate với cặp dấu {} và dấu chấm phẩy cuối cùng
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