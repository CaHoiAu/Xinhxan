using System;
namespace Bai02
{
    class Bai02
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] s = new int[n];
            int i=0;
            Nhap(i, n, ref s);
            In(i, n, ref s);
            Console.WriteLine("Tong cac phan tu chan trong day la: " + TinhTongChan(out i, n, s));
            Console.WriteLine("Phan tu lon nhat trong day la: " + TimMax(s));
            Console.WriteLine("Day sau khi duoc sap xep tang dan la:");
            SapXepTangDan(i, n, ref s);
            In(i, n, ref s);
        }
        static void Nhap(int i, int n, ref int[] s)
        {
            for (i = 0; i < n; i++)
            {
                s[i] = int.Parse(Console.ReadLine());
            }
        }
        static void In(int i, int n, ref int[] s)
        {
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("s[{0}]:{1}", i, s[i]);
            }
        }
        static int TinhTongChan(out int i, int n, int[] s)
        {
            i = 0;
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                if (s[i] % 2 == 0)
                {
                    sum += s[i];
                }
            }
            return sum;
        }
        static int TimMax(params int[] s)
        {
            int i;
            int max = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (max <= s[i])
                    max = s[i];
            }
            return max;
        }
        static void SapXepTangDan(int i, int n, ref int[] s)
        {
            for (i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (s[i] > s[j])
                    {
                        int a = 0;
                        a = s[i];
                        s[i] = s[j];
                        s[j] = a;
                    }
                }
            }
        }
    }
}