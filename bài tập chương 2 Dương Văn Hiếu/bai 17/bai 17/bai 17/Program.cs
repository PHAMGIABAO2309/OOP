using System;
namespace bai_17
{
    class bai17
    {
        int n, m;
        int[,] arr;
        public bai17()
        {
            Console.WriteLine("Nhap n hang: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap m cot: ");
            m = int.Parse(Console.ReadLine());
            arr = new int[n, m];
            //Nhập các phần tử vào trong ma trận:
            Console.Write("Nhap cac phan tu vao trong ma tran: \n");
            for (int i = 0; i < n;i++)
            {
                for(int j = 0; j<m; j++)
                {
                    Console.Write("Phan tu - [{0}], [{1}]: ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //in ra ma trận
            Console.Write("In ma tran:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(" {0} ", arr[i, j]);
                Console.Write("\n");
            }
        }

        //ham tinh tong cac phan tu nam tren duong cheo chinh va duong cheo phu
        public void S_Namtren_DuongCheoChinh_DuongCheoPhu()
        {
            
            //Tổng nằm trên đường chéo chính
            long S1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i < j)
                        S1 = S1 + arr[i, j];
                }
            }
            Console.WriteLine("Tong nam tren duong cheo chinh: " + S1);

            //Tổng nằm trên đường chéo phụ
            long S2 = 0;
            for (int i = 0; i > n; i++)
            {
                for (int j = 0; j > m; j++)
                {
                    if (i > j)
                        S2 = S2 + arr[i, n-1-i];
                }

            }
            Console.WriteLine("Tong nam tren duong cheo phu: " + S2);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            bai17 b17 = new bai17();
            b17.S_Namtren_DuongCheoChinh_DuongCheoPhu();
            Console.ReadKey();
        }
    }
}