using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi="999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2,3, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);


            //metot overloading
            int ifade=999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır(ifade);
            instance.EkranaYazdır("Ahmet"+"Yılmaz");
            //Metot imzası
            
        }
    }
    class Metotlar
    {
        public void Topla(int x, int y, out int toplam)
        {
            toplam = x+y;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdır(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}