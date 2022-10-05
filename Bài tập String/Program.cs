
using System;

namespace Bài_tập_String
{
    class Program
    {
        public static string Revesrve(string index)
        {
            char[] arr = index.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            string name = "Greenwich's Club of Developers";
            foreach(var x in name){
                Console.Write(" " + x);
            }
             string b = name.ToLower();
             string c = name.ToUpper();
             int size = name.Length;
             string daoname = Revesrve(name);
             string catchuoi = name.Substring(12, 4);
            int dem = 0;
           int lan = -1;
           int idx = -1;
           char solan = 'e';
           while (dem != -1)
           {
               dem =name.IndexOf(solan, idx + 1);
               lan += 1;
               idx = dem;
           } 
             Console.WriteLine("\nDo dai cua chuoi: " + size);
             Console.WriteLine("Tao chu cai thuong: " + b);
             Console.WriteLine("Tao chu in hoa: "+ c);
             Console.WriteLine("chuoi moi:" + catchuoi);
             Console.WriteLine("Dao nguoc chuoi: " + daoname );
             Console.Write("e da xuat hien:" + lan + " lan.");

             Console.ReadLine();
          
            
        }
    }
}
