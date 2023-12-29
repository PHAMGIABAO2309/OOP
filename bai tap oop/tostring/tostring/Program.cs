using System;
namespace tostring
{
    class Person
    {
        public string name;
        public Person(string ten)
        {
            name = ten;
        }
        public override string ToString()
        {
            return " Hello ! My name is " + name;
        }
    }
    class DS
    {
        Person[] ds;
        public void Nhap()
        {
            int n;
            Console.WriteLine("Nhap so luong ten : ");
            n = Convert.ToInt32(Console.ReadLine());
            ds = new Person[n];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("\n Nhap ten thu {0}: ", i);
                ds[i] = new Person(Console.ReadLine());

            }
            Console.WriteLine("\n Thong tin vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DS ds = new DS();
            ds.Nhap();
        }
    }
}
