using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace vidu_overload_phuongthuc
{
    class OverloadProgram
    {
        public Byte Tong(Byte a, Byte b)
        {
            return (Byte)(a + b);
        }
        public Int16 Tong(Int16 a,Int16 b)
        {
            return (Int16)(a + b);
        }
        public Int32 Tong(Int32 a,Int32 b)
        {
            return (Int32)(a + b);
        }
        public Int64 Tong(Int64 a,Int64 b)
        {
            return (Int64)(a + b);
        }
        public Double Tong(Double a, Double b)
        {
            return (Double)(a + b);
        }
        static void Main(string[] args)
        {
            Byte a_Byte = 200, b_Byte = 200;
            Int16 a_Int16 = 20000, b_Int16 = 20000;
            Int32 a_Int32 = 20000, b_Int32 = 20000;
            Int64 a_Int64 = 2000000, b_Int64 = 2000000;
            Double a_Double = 2000000, b_Double = 2000000;
            OverloadProgram p = new OverloadProgram();
            Console.Write("Minh hoa phuong thuc Overload");
            Console.Write("\n Byte: a= {0} ; b= {1} ; Tong= {2} ", a_Byte, b_Byte, p.Tong(a_Byte, b_Byte));
            Console.Write("\n Int16: a= {0} ; b= {1} ; Tong= {2} ", a_Int16, b_Int16, p.Tong(a_Int16, b_Int16));
            Console.Write("\n Int32: a= {0} ; b= {1} ; Tong= {2} ", a_Int32, b_Int32, p.Tong(a_Int32, b_Int32));
            Console.Write("\n Int64: a= {0} ; b= {1} ; Tong= {2}", a_Int64, b_Int64, p.Tong(a_Int64, b_Int64));
            Console.Write("\n Double: a= {0} ; b= {1} ; Tong= {2} ", a_Double, b_Double, p.Tong(a_Double, b_Double));
            Console.ReadKey();
        }
    }
}