
using System;

namespace KiemtraTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            string option="yes";
            while(option=="yes"){
                Nhaplai:
            int a, b,c;
             Console.WriteLine("Nhap do dai canh a: ");
             a =int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap do dai canh b: ");
            b =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap do dai canh c");
            c = int.Parse(Console.ReadLine());
           if(a<=0||b<=0||c<=0)
           {
              
               Console.WriteLine("Deo co do dai nao am ca! nhap lai do dai cac canh");
               goto Nhaplai;
           }
           else 
           {
               int hieua= b-c, hieub= a-c, hieuc=a-b, tonga=b+c, tongb=a+c, tongc=a+b;
              if(hieua < a && a < tonga && hieub < b && b < tongb && hieuc < c && c < tongc)
              {
                  Console.WriteLine("3 canh nay tao thanh mot tam giac");
                  if(a==b||b==c||c==a)
                  {
                      Console.WriteLine("Day la tam giac can");
                  }
                  else if(a==b&& b==c)
                  {
                      Console.WriteLine("Day la tam giac deu");
                  }
              }
              else
              {
                  Console.WriteLine("3 canh nay ko tao thanh mot tam giac! Vui long nhap lai do dai 3 canh");
                  goto Nhaplai;
              }
               
           }
            Console.WriteLine("Nhap yes de tiep tuc");
            option=Console.ReadLine();
            } 
        }
    }
}
