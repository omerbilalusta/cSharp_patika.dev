using System;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            RecordActions recordActions = new RecordActions();
            do{
                Console.WriteLine("\n\nLütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                secim = Int32.Parse(Console.ReadLine());

                if(secim == 1){
                    recordActions.kayitEkle();
                }
                else if(secim == 2){
                    recordActions.kayitSil();
                }
                else if(secim == 3){
                    recordActions.kayitGuncelle();
                }
                else if(secim == 4){
                    recordActions.kayitListele();
                }
                else if(secim == 5){
                    recordActions.aramaYapma();
                }
                else{
                    Console.WriteLine("Hatalı seçim!!");
                }
            }
            while(true);
        }
    }
}