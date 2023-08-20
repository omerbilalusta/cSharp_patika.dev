namespace Proje2
{
    class Board
    {
        public static List<Card> toDoLine = new List<Card>(); //Her bir line için ayrı ayrı liste oluşturdum çünkü bu listeler Card nesnelerini tutacaklar.
                                                                //static olmalarının sebebi ise listelerin içindeki nesneleri BoardActions.cs 'de ki methotlarla
                                                                //güncellemeye çalıştığımda fonksiyon normal ve doğru şekilde çalışıyor ancak nesneler
                                                                //bundan sonra tekrar kontrol edildiğinde güncellenmedikleri gözüküyordu.
        public static List<Card> inProgressLine = new List<Card>();
        public static List<Card> doneLine = new List<Card>();
    }
}