using System;

namespace inracacngaytrong_thang
{
    class Program
    {
        static void Main(string[] args)
        {
         int day, month, year;
            Console.WriteLine("Nhap ngay");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam");
            year = int.Parse(Console.ReadLine());
            DateTime dateTime = new DateTime(year, month, day);
            DateTime newday = dateTime.AddDays(1000);
            Console.WriteLine("{0}",dateTime);
            Console.WriteLine(" 1000 days later {0}", newday);
            Console.WriteLine("{0:dddd}", newday);
            Console.ReadLine();


        }
    }
}
