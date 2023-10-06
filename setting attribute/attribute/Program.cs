using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Reflection.Metadata.Ecma335;

namespace attribute //vi du thao tac len thuoc tinh
{
    class TestResult
    {
        public readonly string ID;

        private string Name1;
        public string Name
        {
            get { return Name1; }
            set { Name1 = value; }
        }
        private string Address1;
        public string Address
        {
            get { return Address1; }
            set { Address1 = value; }
        }
        private int Age1;
        public int Age
        {
            get { return Age1; }
            //rang buoc gia tri cho thuoc tinh
            set
            {
                if (value > 100)
                    Age1 = 100;
                else
                    if (value <= 0)
                    Age1 = 20;
                else Age1 = value;
            }
        }
        private double Grade1;
        public double Grade
        {
            get { return Grade1; }
            // ràng buộc giá trị cho thuộc tính
            set
            {
                if (value > 10)
                    Grade1 = 10;
                else if (value < 0)
                    Grade1 = 0;
                else Grade1 = value;
            }

        }
        //khai bao phuong thucc
        public string Result()
        {
            if (Grade < 5)
                return "Rot";
            else return "Dau";
        }
        private string Password1;
        // khai bao thuoc tinh Password chi ghi
        public string Password //chi ghi,khong duoc truy xuat
        {
            set { Password1 = value; }
        }
        private string DefaultPass1;
        public string DefaultPass
        {
            get { return DefaultPass1; }
        }
        public TestResult()
        {
            Console.Write("Nhap ID: ");
            ID = Console.ReadLine();
            DefaultPass1 = "pass@OOP";
        }
        static void Main(string[] args)
        {
            TestResult res1 = new TestResult();
            Console.Write("Nhap ten: ");
            res1.Name = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            res1.Address = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            res1.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem: ");
            res1.Grade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap password moi: ");
            res1.Password = Convert.ToString(Console.ReadLine());
            Console.WriteLine("----------Ket qua-----------");
            Console.WriteLine("ID = {0} , Name= {1}; \n Address= {2};", res1.ID, res1.Name, res1.Address);
            Console.WriteLine("Age= {0}; \n Grade= {1}; \n Result = {2}; \n DefaultPass= {3} ", res1.Age, res1.Grade, res1.Result(), res1.DefaultPass);
            Console.ReadLine();
        }
    }
}