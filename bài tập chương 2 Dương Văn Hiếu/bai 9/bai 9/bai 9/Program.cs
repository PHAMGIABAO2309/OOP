using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace bai_9_bai_10
{
    class bai9
    {
        int n;
        public bai9()
        {
            Console.WriteLine("Nhap n bai 9: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void uocsole()
        {
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0 )
                    if(i % 2 == 1)
                        Console.WriteLine("Cac uoc so le la: " + i);
            }
        }
    }
    class bai10
    {
        int n;
        public bai10()
        {
            Console.WriteLine("Nhap n bai 10: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void uocsochan()
        {
            for(int i = 1; i<=n; i++)
            {
                if (n % i == 0)
                    if (i % 2 == 0)
                        Console.WriteLine("Cac uoc so chan la: " + i);
            }    
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            bai9 b9 = new bai9();
            b9.uocsole();
            bai10 b10 = new bai10();
            b10.uocsochan();
            Console.ReadKey();
        }
    }
}