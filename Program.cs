using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dongusu_ve_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları yazdırma 
            Console.Write("Lütfen Bir Sayı Giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(sayi+"nın içindeki tek sayılar----");
            for (int i = 1; i<=sayi; i ++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("--------------------------------------------------------");
            // 1 den 1000 arasındaki tek ve çiftlerin toplamı 
            int tektoplam = 0;
            int cifttoplam = 0;
            for (int j=1;j<=1000;j++)
            {
                if (j%2 == 1)
                {
                    tektoplam += j;
                }
                else
                {
                    cifttoplam += j;
                }
                
            }
            Console.WriteLine("1000'e kadar ki teklerin toplamı : " + tektoplam);
            Console.WriteLine("1000'e kadar ki çiftlerin toplamı : " + cifttoplam);
            // Berak- Continue
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Break");
            for (int k=1;k<10;k++)
            {
                if (k == 4)
                    break;
                Console.WriteLine(k);
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Continue");
            for (int l = 1; l < 10; l++)
            {
                if (l == 4)
                    continue;
                Console.WriteLine(l);
            }
            Console.ReadLine();

        }
    }
}
