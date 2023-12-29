using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhamGiaBao_022101023;
namespace PhamGiaBao_022101023;
class Diem
{
    public float X
    {
        get; set;
    }

    public float Y
    {
        get; set;
    }
    public void Nhap_Toa_Do()
    {
        Console.Write("Nhap Toa do X: ");
        X = float.Parse(Console.ReadLine());
        Console.Write("Nhap Toa do Y: ");
        Y = float.Parse(Console.ReadLine());
    }

    public void Xuat_Toa_Do()
    {
        Console.Write("({0}, {1})", X, Y);
        Console.WriteLine();
    }
    public static bool operator ==(Diem temp, Diem temp2)
    {
        bool status = false;
        if (temp2.X == temp.X && temp2.Y == temp.Y) status = true;
        return status;
    }
    public static bool operator !=(Diem temp, Diem temp2)
    {
        bool status = false;
        if (temp2.X != temp.X && temp2.Y != temp.Y) status = true;
        return status;
    }
    public static double Do_Dai_Canh(Diem A, Diem B)
    {
        return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
    }
}

class HinhBinhHanh
{
    public Diem A = new Diem();
    public Diem B = new Diem();
    public Diem O = new Diem();
    public Diem C = new Diem();
    public Diem D = new Diem();

    public void Nhap_Diem()
    {
        do
        {
            Console.WriteLine("Diem A: ");
            A.Nhap_Toa_Do();
            Console.WriteLine("Diem B: ");
            B.Nhap_Toa_Do();
            Console.WriteLine("Diem O: ");
            O.Nhap_Toa_Do();
            C.X = 2 * O.X - A.X;
            C.Y = 2 * O.Y - A.Y;
            D.X = 2 * O.X - B.X;
            D.Y = 2 * O.Y - B.Y;
            if (A == B || A == O || O == B || C == B || C == D || D == A)
            {
                Console.WriteLine("Co Diem Chung, Vui Long Nhap Lai: ");
            }
        } while (A == B || A == O || O == B || C == B || C == D || D == A);


    }

    public void Xuat_Diem()
    {
        Console.Write("Toa Do Diem A: ");
        A.Xuat_Toa_Do();
        Console.Write("Toa Do Diem B: ");
        B.Xuat_Toa_Do();
        Console.Write("Toa Do Diem C: ");
        C.Xuat_Toa_Do();
        Console.Write("Toa Do Diem D: ");
        D.Xuat_Toa_Do();
        Console.Write("Toa Do Diem O: ");
        O.Xuat_Toa_Do();
        Console.WriteLine("Chu Vi: " + (Diem.Do_Dai_Canh(A, B) + Diem.Do_Dai_Canh(B, C)) * 2);
    }
}

class Program
{
    static public void Main()
    {
        HinhBinhHanh hinh = new HinhBinhHanh();
        hinh.Nhap_Diem();
        hinh.Xuat_Diem();
        Console.ReadLine();
    }
}