using System;
namespace OVERRIDE
{
    class A1
    {
        public virtual void AA()
        {
            Console.WriteLine("In tu AA cua class A1");
        }
    }
    class A2 : A1
    {
        public override void AA()
        {
            base.AA();
            Console.WriteLine("Pham Gia Bao");
        }
        public void BB()
        {
            Console.WriteLine("In tu BB cua class A2");
        }
        public void CC()
        {
            Console.WriteLine("Ahii do ngoc");
        }
    }
    class A3 : A2
    {
        public new void BB()
        {
            Console.WriteLine("In tu BB cua class A3");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            A3 a3 = new A3();
            a3.AA();
            a3.BB();
            Console.ReadLine();
        }
    }
}