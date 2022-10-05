using System;

namespace nhap
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("nhap so n:");
            int n= Convert.ToInt32(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine($"{n} la so chan");
            } else
            {
                Console.WriteLine($"{n} la so le");
            }
        } 
    }
}           
    
  


        
    

