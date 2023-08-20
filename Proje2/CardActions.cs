namespace Proje2
{
    class CardActions : ICardActions
    {
        List<Card> cardList = new List<Card>();
        Dictionary<int, string> personList = new Dictionary<int, string>();
        BoardActions boardActions = new BoardActions();
        public CardActions(){                                                               //Varsayılan kişilerin oluşturulması için kurucu metot ile bir kaç nesneyi personList'e ekledik.
            personList.Add(1592, "Hakan Yılmaz");
            personList.Add(5353, "Ayşe Genç");
            personList.Add(3434, "Yavuz Çoban");
            personList.Add(6134, "Faruk Kaya");
            personList.Add(4232, "Gokhan Uner");
        }
        
        public void kartEkle()
        {
            Console.WriteLine("Başlık Giriniz                                  : ");
            string kartTitle=Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                  : ");
            string kartContent=Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            Boyut kartBoyut = (Boyut)(Int32.Parse(Console.ReadLine())-1);
            Console.WriteLine("Kişi Seçiniz (Kisinin ID'ini giriniz.)          : ");
            int kisiId = Int32.Parse(Console.ReadLine());
            string personName = personList.FirstOrDefault(x=> x.Key == kisiId).Value;       //Girilen ID'ye ait kişinin adını alıyoruz

            if(personList.ContainsKey(kisiId)){
                Card newCard = new Card(kartTitle, kartContent, kartBoyut, personName);     //Kişi bulunursa Card oluşturuluyor. Ve boarActions ile toDoLine listesine ekleniyor.
                newCard.Boyut = kartBoyut;
                cardList.Add(newCard);                                                      //cardList listesine ekleniyor
                boardActions.lineEkle(newCard);
            }
            else{
                Console.WriteLine("ID bulunamadı.");
            }
        }

        public void kartGuncelle()
        {
            Card card = kartArama();
            
            if(card != null){
                Console.WriteLine("Kartın güncellemek istediğiniz özelliğini seçiniz: ");
                Console.WriteLine("* Kart Başlığı: (1)");
                Console.WriteLine("* Kart İçeriği: (2)");
                Console.WriteLine("* Kart Büyüklüğü: (3)");
                Console.WriteLine("* Kart kişisi: (4)");
                int secim = Int32.Parse(Console.ReadLine());

                if(secim == 1){
                    Console.WriteLine("Yeni başlık giriniz: ");                             //Yeni başlığı kullanıdan alıyoruz.
                    string title = Console.ReadLine();
                    cardList.ForEach(x=> {if(x == card) x.Title = title;});                 //Bu başlığın hangi nesneye ait olduğunu cardList'te arıyoruz. Ve bulunca ilgili elementin(nesnenin) başlığını güncelliyoruz.
                    card.Title = title;                                                     //Tutuğumuz nesnenin ilgili kısmını birde burada günclleyip BoardActions.cs'de bulunan listlerin güncellenmesi için birde oraya gönderiyoruz.
                    boardActions.guncelle(card);
                }
                else if(secim == 2){
                    Console.WriteLine("Yeni içerik giriniz: ");
                    string yeniIcerik = Console.ReadLine();
                    cardList.ForEach(x=> {if(x == card) x.Content = yeniIcerik;});
                    card.Content = yeniIcerik;
                    boardActions.guncelle(card);
                }
                else if(secim == 3){
                    Console.WriteLine("Yeni büyüklük giriniz: ");
                    Boyut yeniBoyut = (Boyut)(Int32.Parse(Console.ReadLine())-1);
                    cardList.ForEach(x=> {if(x == card) x.Boyut = yeniBoyut;});
                    card.Boyut = yeniBoyut;
                    boardActions.guncelle(card);
                }
                else{
                    Console.WriteLine("Yeni kisinin ID'sini giriniz: ");
                    int yeniId = Int32.Parse(Console.ReadLine());
                    if(personList.ContainsKey(yeniId)){
                        string isim = personList.FirstOrDefault(x=> x.Key == yeniId).Value;
                        cardList.ForEach(x=> {if(x == card) x.KisiName = isim;});
                        boardActions.guncelle(card);
                    }
                    else{
                        Console.WriteLine("ID bulunamadı.");
                    }

                }
            }
            else{
                Console.WriteLine("Aradığınız krtiterlere uygun kart bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int secim = Int32.Parse(Console.ReadLine());
                if(secim == 2){
                    kartGuncelle();
                    return;
                }
            }
        }

        public void kartSil()
        {
            Card card = kartArama();
            if(card != null){
                boardActions.kartSil(card);
                cardList.Remove(card);
                Console.WriteLine("{0} başlıklı kart başarıyla silindi.", card.Title);
            }
            else{
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int secim = Int32.Parse(Console.ReadLine());
                if(secim == 2){
                    kartSil();
                }
            }
        }

        public void kartTasi() 
        {
            Card card= kartArama();

            if(card != null){
                Console.WriteLine("{0} başlıklı kartı atamak istediğiniz sırayı seçiniz.", card.Title);
                Console.WriteLine("* 'To Do Line' için : (1)");
                Console.WriteLine("* 'In Progress Line' için : (2)");
                Console.WriteLine("* 'Done Line' için : (3)");
                int secim = Int32.Parse(Console.ReadLine());
                boardActions.kartTasi(card, secim);
            }
            else{
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int secim = Int32.Parse(Console.ReadLine());
                if(secim == 2){
                    kartTasi();
                }
            }

        }

        private Card kartArama(){ //Kart aramasını her metot içinde yapmak yerine bu işlem için özel bir metot oluşturdum.
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçiniz.");
            Console.WriteLine("Kart başlığını giriniz. ");
            string kartBasligi = Console.ReadLine();
            Card Card = null;
            cardList.ForEach(x=> {if(x.Title == kartBasligi){Card = x;}});
            return Card;
        }
    }
}