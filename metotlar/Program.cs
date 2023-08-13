using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2;
            int b=3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            metotlar ornek = new metotlar();

            ornek.EkranaYazdır(sonuc.ToString());
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            ornek.EkranaYazdır(Convert.ToString(a+b));
            int sonuc2 = ornek.artırVeTopla(ref a, ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a+b));
        }
        static int Topla(int x, int y)
        { 
            return x+y;
        }
    }

    class metotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public int artırVeTopla(ref int x, ref int y)
        {
            x+=1;
            y+=1;
            return x+y;
        }
    }
}