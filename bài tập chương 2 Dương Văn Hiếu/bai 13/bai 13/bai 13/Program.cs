using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace bai_13
{
    class bai13
    {
        int n;
        public bai13()
        {
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void demsoluongchuso()
        {
            int count = 1;
            for(int i = 0; i<= n; i++)
            {
                n /= 10;
                count++;
            }
            
            Console.WriteLine("So Luong Chu So: " + count);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            bai13 b13 = new bai13();
            b13.demsoluongchuso();
            Console.ReadKey();
        }
    }
}