using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if(i%2 ==1)
                {
                    Console.WriteLine(i);
                }
            }

            int tekToplam=0;
            int ciftToplam=0;
            for (int i = 0; i < 1000; i++)
            {
                if(i%2==1)
                {
                    tekToplam+=i;
                }
                else
                {
                    ciftToplam+=i;
                }
            }
            Console.WriteLine("Tek sayıların toplamı= "+tekToplam);
            Console.WriteLine("Cift sayilarin toplamı= "+ ciftToplam);

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}