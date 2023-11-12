using System;
interface Iluutru
{
    void Read(); //phuong thuc
    void Write(object obj); //phuongthuc co 1 tham so la 1 doi tuong
    int Status //thuoc tinh
    {
        get;
        set;
    }
}
class tailieu : Iluutru
{
    /* Lớp "tailieu" triển khai giao diện "iluutru". Lớp này có một constructor 
     nhận một chuỗi và in ra thông báo tạo tài liệu với chuỗi đó. */
    public tailieu(string s)
    {
        Console.Write("Tao tai lieu voi: {0} ", s);
    }
    /* Định nghĩa phương thức "read" của lớp "tailieu". 
     Phương thức này in ra thông báo thực hiện 
    phương thức "read" trong giao diện "iluutru". */
    public void Read()
    {
        Console.WriteLine("Thuc hien phuong thuc Read trong Iluutru ");
    }
    public void Write(object o)
    {
        Console.WriteLine("Thuc hien phuong thuc Write cho Iluutru ");
    }
    public int Status
    {
        get
        {
            return status;
        }
        set
        {
            status = value;
        }
    }
    private int status = 0;
}
class tester
{
    static void Main()
    {
        /* Tạo một đối tượng "doc" thuộc lớp "tailieu" với tham số là một chuỗi.
         Điều này sẽ gọi constructor trong lớp "tailieu" và 
        in ra thông báo tạo tài liệu với chuỗi. */
        tailieu doc = new tailieu("Tap chi the thao");
        doc.Status = -1;
        doc.Read();
        Console.WriteLine("Tinh trang tai lieu: {0} ", doc.Status);
        Iluutru isdoc = (Iluutru)doc;
        isdoc.Status = 0;
        isdoc.Read();
        Console.WriteLine("Tinh trang cua Iluutru: {0} ", isdoc.Status);
    }
}