
using System;

namespace hoa_don_thanh_toan_tien_dien
{
    class Program
    {
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
        static void XuatHienMang(int[] arr)
        {
            Console.WriteLine("Cac so nguyen trong mang la: ");
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(""+arr[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr =NhapMang();
            XuatHienMang(arr);
            Console.Write("ID: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Ten: ");
            Console.ReadLine();
            Console.WriteLine("Nhap so don vi dien da tieu thu: ");
            double dien=int.Parse(Console.ReadLine());
            double ceiling = Math.Ceiling(dien);
            Console.WriteLine("Hoa don thanh toan tien dien");
            Console.WriteLine("len den 199 tuong duong voi 1.2$");
            Console.WriteLine("200 den duoi 400 tuong duong voi 1.5$");
            Console.WriteLine("400 den duoi 600 tuong duong voi 1.8$");
            Console.WriteLine(" lon hon hoac bang 600 tong duong voi 2.0$");
            Console.WriteLine("Neu tien dien vuot qua 400 thi se them 15% phu phi");
            if(dien < 100)
            {
                Console.WriteLine("Ban da tieu thu het 100Rs");
                Console.WriteLine("So tien ban phai tra la 1200$");
            }
            else if(100<= dien && dien<200)
            {
                Console.WriteLine($"Ban da tieu thu het: {dien}");
                Console.WriteLine($"So tien ban phai tra la: {dien *1.2}");
            }
             else if(200<= dien && dien<400)
            {
                Console.WriteLine($"Ban da tieu thu het: {dien}");
                Console.WriteLine($"So tien ban phai tra la: {dien *1.5}");
            }
             else if(400<= dien && dien<600)
            {
                Console.WriteLine($"Ban da tieu thu het: {dien}");
                Console.WriteLine($"So tien phu phi ma ban phai tra la: {dien*1.8*0.15}");
                Console.WriteLine($"So tien ban phai tra la: {(dien *1.8)+(dien*1.8*0.15)}");
            }
             else if(dien>=600)
            {
                Console.WriteLine($"Ban da tieu thu het: {dien}");
                Console.WriteLine($"So tien phu phi ma ban phai tra la: {dien*2*0.15}");
                Console.WriteLine($"So tien ban phai tra la: {(dien *2)+(dien*2*0.15)}");
            }
            Console.ReadLine();
        }
    }/*double number = 1.5362
  
int ceiling = Math.Ceiling(number)*/ 


}
