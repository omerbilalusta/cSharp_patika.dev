using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //1'den başlayarak yazılan sayıya kadarki sayıların ortalaması
            Console.WriteLine("Sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);


            // 'a' dan z'ye kadar tüm harfleri konsola yazdırma
            char chrachter='a';
            while (chrachter<= 'z')
            {
                Console.Write(chrachter);
                chrachter++;
            }

            Console.WriteLine("\n******** Foreach ******");
            string[] arabalar = {"BMW", "Ford", "Audi", "GTR"};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}