using System;
namespace vd
{
    class Dongvat
    {
        protected double cannang;
        protected double chieucao;
        protected static int chan;
        public void thongtin()
        {
            Console.Write("Can nang: " + cannang + "\n Chieu cao: " + chieucao + "\n Chan: " + chan);

        }
    }
    class Meo : Dongvat //lop Meo ke thua lop Dong Vat
    {
        public Meo()
        {
            /* cac thuoc tinh Cannang, Chieucao, Chan co pham vi protected
             nen duoc phep ke thua, tu do lop Meo co the su dung ma khong can phai khai bao*/
            cannang = 500;
            chieucao = 20;
            chan = 2;
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Meo meoden = new Meo();
            meoden.thongtin();
            Console.ReadKey();
        }
    }

}