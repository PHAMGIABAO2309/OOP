using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace vidu_params
{
    class Program
    {
        public static void PrintUseParams( params Int32[] list )
        {
            Console.Write("Co {0} tham so co gia tri: ", list.Length);
            for(int i = 0; i < list.Length; i++)
            {
                Console.Write("{0}", list[i]);
            }
            Console.WriteLine();
        }
        public static void PrintUseParamsObject(params object[] list)
        {
            Console.Write("Co {0} tham so co gia tri: ", list.Length);
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("{0}", list[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Int32 a = 1, b = 2, c = 3, d = 4, e = 5, f = 6;
            PrintUseParams(a, b, c, d, e, f);
            PrintUseParamsObject(a,  'A',  c,  "Duong Van Hieu",  e,  "OOP");
            Console.ReadKey();
        }
    }
}