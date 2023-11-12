using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace bai_7
{
    class bai7
    {
        int n;
        double x,S=0;
        public bai7()
        {
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap x: ");
            x = Convert.ToDouble(Console.ReadLine());
        }
        public void tinh_x_mu_n()
        {
            
            for(int i = 1; i <= n; i++)
            {
                S = S + Math.Pow(x, i);
            }
            Console.WriteLine("Tong S = {0} ",S);
        }
        static void Main(String[] args)
        {
            bai7 b7 = new bai7();
            b7.tinh_x_mu_n();
            Console.ReadKey();
        }
    }
    
        
    
}