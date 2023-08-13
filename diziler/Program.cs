using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi", "Köpek", "Balık"};

            int [] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3]=10;

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngüler dizi kullanımı
            // klavyeden girilen n tane sayının ortalamsını hesaplayan program
            Console.Write("Dizinin eleman sayınsını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int [] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz:", i+1);
                sayiDizisi[i]= int.Parse(Console.ReadLine());
            }
            int toplam=0;
            foreach (var item in sayiDizisi)
            {
                toplam+= item;
            }
            Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);
        }
    }
}