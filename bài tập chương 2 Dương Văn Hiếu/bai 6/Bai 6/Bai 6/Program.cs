using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai_6
{
    class bai6
    {
        int n;
        public bai6() //ham constructor
        {
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void LietKeUocSo()
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine("{0} ", i);
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            bai6 b6 = new bai6();
            b6.LietKeUocSo();
            Console.ReadKey();
        }
    }
}