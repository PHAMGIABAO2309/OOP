using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace c2b1
{
    class lophoc
    {
        public string malop;
        private string tenlop;
        public lophoc()
        {
            Console.WriteLine("Nhap ma lop: ");
            malop = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ten lop: ");
            tenlop = Convert.ToString(Console.ReadLine());
        }
        public string getmalop()
        {
            return malop;
        }
        public string gettenlop()
        {
            return tenlop;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            lophoc[] dslop = new lophoc[3];
            for(int i = 0; i< dslop.Length;i++)
            {
                Console.WriteLine("Nhap lop thu {0}", i);
                dslop[i] = new lophoc();
            }
            Console.WriteLine("Danh sach lop da nhap");
            for(int i = 0; i < dslop.Length;i++)
            {
                Console.WriteLine("{0}.{1} - {2}", i, dslop[i].malop, dslop[i].gettenlop());
                
            }
            Console.ReadKey();
        }
    }
}