using System;
namespace BASE
{
    class class1
    {
        public virtual void A1()
        {
            Console.WriteLine("In tu A1 (1)");
        }
    }
    class class2 : class1
    {
        public override void A1()
        {
            base.A1();
            Console.WriteLine("In tu A1 cua (2)");
        }
        public void A2()
        {
            Console.WriteLine("In tu (2)");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            class2 cls = new class2();
            cls.A1();
            cls.A2();
            Console.ReadLine();
        }
    }
}