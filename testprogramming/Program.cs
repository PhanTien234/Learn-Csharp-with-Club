
using System;

namespace testprogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =NhapMang();
            /*bool[] b= phanLoai(arr);*/
            XuatHienMang(arr);
           Ketqua(arr, b);
        }
        static void XuatHienMang(int[] arr)
        {
            Console.WriteLine("Cac so nguyen trong mang la: ");
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(""+arr[i]);
            }
            Console.WriteLine();
        }

       static void Ketqua(int[] arr, bool[] b)
        {
            Console.WriteLine("Ket qua: ");
            int n=arr.Length;
            for (int i=0; i<n; i++)
            {
                if(b[i]){
                    int dem=Dem(arr, arr[i]);
                    Console.WriteLine($"{arr[i]} xuat hien {dem} lan");
                }
            }
        }

        /*static int Dem(int[] arr, int x)
        {
            int dem =0;
            for (int i=0; i<arr.Length; i++)
            {
                if(x== arr[i])
                {
                    dem++;
                }
            }
            return dem;
        }*/

       /* static bool[] phanLoai(int[] arr)
        {
            bool[] a = new bool[arr.Length];
            int n = arr.Length;
            for(int i=0; i<n; i++)
            {
                bool x =true;
                for(int k=0; k<i; k++)
                {
                    if(arr[i] == arr[k])
                    {
                        x=false;
                        break;
                    }
                }
                a[i]=x;
            }
            return a;
        }*/
        static int[] NhapMang()
        {
            int n=0;
            while( n<=0)
            {
                Console.WriteLine("Nhap so phan tu mang: ");
                n= Convert.ToInt32(Console.ReadLine());
            }
            int[] arr = new int[n];
            for (int i=0; i<n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
    }/*Bài 1: Khai báo mảng số nguyên {1,4,5,2,3,4,2,1,1,6,7,7}
a/ Tính tổng các số có trong mảng
b/ In ra các số có trong mảng và số lần xuất hiện của nó
Ví dụ:
Số 1: 3 lần
Số 2: 2 lần
c/ Chia mảng thành mảng chẵn, mảng lẻ. In ra phần tử của từng mảng*/

}
