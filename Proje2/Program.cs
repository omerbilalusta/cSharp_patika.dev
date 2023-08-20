using System;

namespace Proje2
{
    class Program
    {
        static void Main(string[] args){
            CardActions cardActions = new CardActions();
            BoardActions boardActions = new BoardActions();
            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(5) Kart Güncellemek");
                int secim = Int32.Parse(Console.ReadLine());
                if(secim==1){
                    boardActions.boardListele();
                    Console.WriteLine("\n\n");
                }
                else if(secim == 2){
                    cardActions.kartEkle();
                    Console.WriteLine("\n\n");
                }
                else if(secim == 3)
                {
                    cardActions.kartSil();
                    Console.WriteLine("\n\n");
                }
                else if(secim == 4)
                {
                    cardActions.kartTasi(); //kart taşıma işlemi ilk önce CardActions.cs 'de hangi karttan bahsedildiği bulunuyor. Ardından BoardActions.cs 'de taşınma işlemi yapılıyor.
                    Console.WriteLine("\n\n");
                }
                else if(secim == 5)
                {
                    cardActions.kartGuncelle();
                    Console.WriteLine("\n\n");
                }
            } while (true);
        }
    }
}