using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler_forLoop_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {

            // ekrana girilen sayıya kadar olan tek sayıları cıkart

            Console.WriteLine("lutfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());

            for (int i=1; i<=sayac;i++)
            {
                if (i%2==1)
                    Console.WriteLine(i);
            }


            // 1 ile 1000 arasındaki tek ve cift sayıların toplamı

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i <=1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;

            }

            Console.WriteLine("tek toplam:"+tekToplam);
            Console.WriteLine("çift toplam:"+ciftToplam);



            // break,continue

            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

          

            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
         



            Console.ReadLine();
        }
    }
}
