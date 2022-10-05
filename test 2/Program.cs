
using System;

namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {  /*a*/
            int chu_cai, chu_so, ky_tu_dac_biet,l,i;
            chu_cai=chu_so=ky_tu_dac_biet=i=0;
           string chuoi ="Univ&er#@sity.Of.Gr**eenwich@";
           l = chuoi.Length;
           while(i<l)
           {
               if(chuoi[i] >= 'a'&& chuoi[i] <='z'|| chuoi[i] >= 'A'&& chuoi[i] <='Z' )
               {
                    chu_cai++;
               }
               else if( chuoi[i]>='0' && chuoi[i]<='9')
               {
                   chu_so++;
               }
               else
               {
                   ky_tu_dac_biet++;
               }

               i++;
           }
           Console.Write("So chu cai trong chuoi la: {0}\n", chu_cai);
           Console.Write("So chu so trong chuoi la: {0}\n", chu_so);
           Console.Write("So ky tu dac biet  trong chuoi la: {0}\n", ky_tu_dac_biet);
           
         /* b */
         int xuat =0;
         int xuat2 =-1;
         int xuat3 = -1;
         char solanxuathien ='e';
         while(xuat!=-1)
         {
             xuat=chuoi.IndexOf(solanxuathien, xuat3 +1);
             xuat2 +=1;
             xuat3 =xuat;
         }
         Console.WriteLine("e da xuat hien: " +xuat2+ "lan.");
           /*c*/
           string the= chuoi.Replace("."," ");
           string the2= the.Replace("*", "");
           string the3 = the2.Replace("&","");
           string the4 = the3.Replace("#","");
           string the5 = the4.Replace("@","");
           Console.WriteLine(the);
           Console.WriteLine(the5);
           Console.ReadLine();
           
        }
    }/*Bài 2: Xử lý chuỗi
Khai báo chuỗi :  "Univ&er#@sity.Of.Gr**eenwich@"
a/ Đếm và in ra số kí tự trong chuỗi (Không dùng thuộc tính Length của chuỗi)
b/ Đếm và in ra số lần xuất hiện của kí tự 'e'
c/
- Thay kí tự '.' bằng kí tự trắng ' ' để được chuỗi mới: "Univ&er#@sity Of Greenwich@"
- Xoá các kí tự đặc biệt
Điểm cộng: in ra số kí tự đã bị xoá
- In ra chuỗi mới (Kết quả mong đợi: "University Of Greenwich")
Gợi ý: Mảng kí tự cần xoá trong chuỗi: { '&', '#', '@', '*' } hoặc chuỗi "&#@*"*/
}
