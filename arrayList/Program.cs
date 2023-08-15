using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        public static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList arrayList = new ArrayList();
            // arrayList.Add("Ayşe");
            // arrayList.Add(2);
            // arrayList.Add(true);
            // arrayList.Add('A');

            // Console.WriteLine(arrayList[1]);

            // foreach (var item in arrayList)
            // {
            //     Console.WriteLine(item);
            // }

            //AddRange, birden fazla elemanı toplu halde eklemek
            Console.WriteLine("**** AddRange ****");
            // string[] renkler={"kırmızı","sarı","yeşil"};
            List<int> sayılar = new List<int>(){1,3,8,7,9,92,5};
            
            // arrayList.AddRange(renkler);
            arrayList.AddRange(sayılar);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("***** Sort ****");
            arrayList.Sort();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Binary Search, dizi ilk önce sıralanıp ardından kullanılmalı çünkü diğer durumda yanlış index cevabı döndürebiliyor
            Console.WriteLine("***** Binary Seach ****");
            Console.WriteLine(arrayList.BinarySearch(9));

            //Reverse
            Console.WriteLine("***** Reverse ****");
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("***** Clear ****");
            arrayList.Clear();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item); //Boş liste
            }
        }
    }
}