using System;

namespace algoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            methods method = new methods();
            method.soruBir();
            method.soruIki();
            method.soruUc();
            method.soruDort();
        }
    }
    class methods
    {
        public void soruBir()
        {
            int yeniSayi;
            Console.WriteLine("sayi giriniz");
            int sayi= int.Parse(Console.ReadLine());
            if(sayi!=null)
            {
                Console.WriteLine(sayi+" adet sayi giriniz.");
                List<int> sayiList= new List<int>();
                for (int i = 0; i < sayi; i++)
                {
                    yeniSayi=Convert.ToInt32(Console.ReadLine());
                    if (yeniSayi!=null)
                    {
                        sayiList.Add(yeniSayi);
                    }
                }

                for (int i = 0; i < sayi; i++)
                {
                    if(sayiList[i]%2==0)
                    {
                        Console.WriteLine(sayiList[i]);
                    }
                }
            }
        }

        public void soruIki()
        {
            Console.WriteLine("sayi giriniz N");
            int n = int.Parse(Console.ReadLine());

            List<int> nList = new List<int>();
            Console.WriteLine("sayi giriniz M");

            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(n+" adet sayi giriniz.");
            for (int i = 0; i < n; i++)
                nList.Add(Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine("*******");
            int calculatedSayi;
            for (int i = 0; i < n; i++)
            {
                calculatedSayi = nList[i]%m;
                if(calculatedSayi == 0)
                    Console.WriteLine(nList[i]);
            }
        }

        public void soruUc()
        {
            Console.WriteLine("sayi giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n+" adet kelime giriniz");
            List<string> stringList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                stringList.Add(Console.ReadLine());
            }
            stringList.Reverse();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(stringList[i]);
            }
        }
        public void soruDort()
        {
            Console.WriteLine("Bir cümle yaziniz");
            string str = Console.ReadLine();

            string[] strList = str.Split(" ");
            Console.WriteLine("Kelime sayisi = " + strList.Length);
            int sayac=0;
            foreach (var item in str)
            {
                sayac++;
            }
            Console.WriteLine("Harf sayisi = " + (sayac-(strList.Length-1)));
        }
    }
}