using System;
using System.Collections;

namespace algoritma_alistirma2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Koleksiyonlar_Soru_1 soruBir = new Koleksiyonlar_Soru_1();
            //soruBir.soruMain();
            //Koleksiyonlar_Soru_2 soruIki = new Koleksiyonlar_Soru_2();
            //soruIki.soruMain();
            Koleksiyonlar_Soru_3 soruUc = new Koleksiyonlar_Soru_3();
            soruUc.soruMain();
        }
        
    }
    class Koleksiyonlar_Soru_1
    {
        public void soruMain()
        {
            string giris;
            ArrayList asalOlan = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                giris = Console.ReadLine();
                int sayi=0;
                bool result = int.TryParse(giris, out sayi);
                if(result && sayi>0)
                {
                    if(asal(sayi))
                    {
                        asalOlan.Add(sayi);
                    }
                    else{
                        asalOlmayan.Add(sayi);
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen pozitif sayi giriniz.");
                    i--;
                }
            }
            asalOlan.Sort();
            asalOlmayan.Sort();
            foreach (var item in asalOlan)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            foreach (var item in asalOlmayan)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine("Asal olanların"+" elaman sayısı:"+asalOlan.Count +" ortalaması= "+ortalama(asalOlan, asalOlan.Count));
            Console.WriteLine("Asal olmayanların"+" eleman sayısı:"+asalOlmayan.Count +" ortalaması= "+ortalama(asalOlmayan, asalOlmayan.Count));
        }
        static bool asal(int sayi)
        {
            for (int i = 2; i < sayi; i++)
            {
                if(sayi%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        static int ortalama(ArrayList list, int count)
        {
            int toplam=0;
            foreach (var item in list)
            {
                toplam+=Convert.ToInt32(item);
            }
            if(toplam==0)
            {
                return 0;
            }
            return toplam/count;
        }
    }

    class Koleksiyonlar_Soru_2
    {
        public void soruMain()
        {
            int sayi=0;
            int[] sayiArray = new int[20];
            for (int i = 0; i < 20; i++)
            {
                if(Int32.TryParse(Console.ReadLine(), out sayi))
                {
                    sayiArray[i]=sayi;
                }
                else
                {
                    Console.WriteLine("Geçerli bir değer giriniz!!");
                    i--;
                }
            }
            
            List<int> sayiList = new List<int>();
            foreach (var item in sayiArray)
            {
                    sayiList.Add(item); //Array'i liste attık
            }

            sayiList.Sort();//sıraladık

            int sayiListCount = sayiList.Count;
            List<int> kucukBuyukSayiList = new List<int>();
            kucukBuyukSayiList.Add(sayiList[0]);
            kucukBuyukSayiList.Add(sayiList[1]);
            kucukBuyukSayiList.Add(sayiList[2]);
            kucukBuyukSayiList.Add(sayiList[sayiListCount-3]);
            kucukBuyukSayiList.Add(sayiList[sayiListCount-2]);
            kucukBuyukSayiList.Add(sayiList[sayiListCount-1]);

            int toplamKucuk=0;
            int toplamBuyuk=0;
            for(int i=0;i<3;i++)
            {
                toplamKucuk+=kucukBuyukSayiList[i+3];
                toplamBuyuk+=kucukBuyukSayiList[i];
            }

            Console.WriteLine("En kucuk üç sayının ortalaması:"+(double)toplamKucuk/3+" ortalama toplamı:"+toplamKucuk);
            Console.WriteLine("En buyuk üç sayının ortalaması:"+(double)toplamBuyuk/3 +" ortalama toplamı:"+toplamBuyuk);
        }
    }
    class Koleksiyonlar_Soru_3
    {
        public void soruMain()
        {
            string giris = Console.ReadLine().ToString();
            char[] sesliHarfler = {'a','e','i','ı','o','u'};
            char[] ayrilmisString = giris.ToCharArray();
            List<char> list = new List<char>();
            foreach (var item in ayrilmisString)
            {
                if(sesliHarfler.Contains(item))
                {
                    list.Add(item);
                }
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
        }
    }
}