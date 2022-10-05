using System;

namespace nhap
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Phuong trinh bac hai co dang AX*X + BX + C = 0");
           Console.WriteLine("Nhap vao so A");
           float a = float.Parse(Console.ReadLine());
           Console.WriteLine("Nhap vao so B");
           float b = float.Parse(Console.ReadLine());
           Console.WriteLine("Nhap vao so C");
           float c = float.Parse(Console.ReadLine());
           float delta = (b*b) - 4*(a*c);
           Console.WriteLine("Phuong trinh nhap vao la :{0}x*x + {1}x +{2} =0", a,b,c);
           if (a==0)
           { 
               if (b==0)
               {
                   Console.WriteLine("Phuong trinh vo nghiem");
               }
               else 
               {
                   float x = (-c)/b;
                   Console.WriteLine("Phuong trinh co nghiem x = {0}", x);
               }
           }
           else
             {
               if (delta < 0)
             {
             Console.WriteLine("phuong trinh vo nghiem");

              }
              else if (delta>=0)
             {
               double x1=0;
               double x2=0;
               x1 = ((-b) + Math.Sqrt(delta))/ (2*a);
               x2 = ((-b) - Math.Sqrt(delta))/ (2*a);
               Console.WriteLine("Phuong trinh co hai nghiem phan biet: ");
               Console.WriteLine("x1={0}", x1);
               Console.WriteLine("x2={0}", x2);
             }
           
            }
           Console.ReadKey();
        }
    }
}/*Bài 3: Giải phương trình bậc 2: aX^2 + bX + C =0
- Nhập a,b,c. Tính nghiệm
Thử chương trình với các trường hợp sau:
TH1: a=0, b=0 => Kết quả: Phương trình vô nghiệm
TH2: a=0, b=2, c=5 => Kết quả: x= -2.5
TH3: a=1, b=2, c=-3 => x1 = 1, x2 = -3*/

