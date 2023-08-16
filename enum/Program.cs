using System;

namespace cSharpExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik=32;
            if(sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
            else if(sicaklik >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün.");
            else if(sicaklik >= (int) HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi dışarı çıkalım");
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sıcak=25,
        CokSıcak=30
    }
}