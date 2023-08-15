using System;
using System.Collections.Generic;

namespace cSharpExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T--> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.ForEach ile elemanlara erişim
            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renkListesi)
            {
                Console.WriteLine(item);
            }

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));


            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));
        
            //Liste içerisinde Arama

            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu.");
            }

            //Eleman ile indekse erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List'e çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Aslan"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listteyi nasıl temizleriz?
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim="Yılmaz";
            kullanıcı1.Yas=26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim="Çalışkan";
            kullanıcı2.Yas=26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            
            yeniListe.Add(new Kullanıcılar(){
                Isim="Deniz",
                Soyisim="Arda",
                Yas = 24
            });

            foreach (var item in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+item.Isim);
                Console.WriteLine("Kullanıcı Soyisim: "+item.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: "+item.Yas);
            }

            yeniListe.Clear();

        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
    class hackerRank //https://www.hackerrank.com/challenges/30-generics/problem
    {
        public static void  PrintArray<T>(T[] genericArray)
        {
            foreach(var item in genericArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}