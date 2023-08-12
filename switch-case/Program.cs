using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındayız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındayız");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındayız");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındayız");
                    break;
                default:
                    Console.WriteLine("Hatalı veri");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindeyiz");
                    break;
                
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindeyiz");
                    break;

                default:
                    break;
            }
        }
    }
}