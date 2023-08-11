using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Hata alması muhtmel kısmı try içerisinde yazıyoruz.
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi:"+sayi);
            }
            catch (System.Exception ex) //Yakalanan hataları bu kısımda ele alınır.
            {
                Console.WriteLine("Hata: "+ ex.Message.ToString());
            }
            finally // İşlem sonunda çalıştırılmak üzere opsiyonel olarak kullanılan kısım, her halükarda çalışır
            {
                Console.Write("İşlem Tamamlandı.");
            }
            
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Cok küçük veya çok  büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}