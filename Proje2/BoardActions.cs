namespace Proje2
{
    class BoardActions
    {
        public void boardListele(){
            Console.WriteLine("TODO LINE");
            Console.WriteLine("********************");
            foreach (var item in Board.toDoLine)
            {
                Console.WriteLine("Başlık       : {0}", item.Title);
                Console.WriteLine("İçerik       : {0}", item.Content);
                Console.WriteLine("Atanan Kişi  : {0}", item.KisiName);
                Console.WriteLine("Buyukluk     : {0}\n", item.Boyut);
            }
            Console.WriteLine("IN PROGRESS LINE");
            Console.WriteLine("********************");
            foreach (var item in Board.inProgressLine)
            {
                Console.WriteLine("Başlık       : {0}", item.Title);
                Console.WriteLine("İçerik       : {0}", item.Content);
                Console.WriteLine("Atanan Kişi  : {0}", item.KisiName);
                Console.WriteLine("Buyukluk     : {0}\n", item.Boyut);
            }
            Console.WriteLine("DONE LINE");
            Console.WriteLine("********************");
            foreach (var item in Board.doneLine)
            {
                Console.WriteLine("Başlık       : {0}", item.Title);
                Console.WriteLine("İçerik       : {0}", item.Content);
                Console.WriteLine("Atanan Kişi  : {0}", item.KisiName);
                Console.WriteLine("Buyukluk     : {0}\n", item.Boyut);
            }
        }
        public  void kartTasi(Card? newCard, int newLine){                  //Kartlları line'lar arasında taşıma işlemi gerçekleştirir.
            if(newLine == 2){                                               //Kart hangi line'a atılacaksa onunla ilgili seçim CardActions tarafında soruluyor
                Board.inProgressLine.Add(newCard);                          //yapılan seçime göre boardActions tarafında seçilen line'lar dışındakilerden (hangisinden ise)
                if(Board.toDoLine.Contains(newCard))                        //silinmek suretiyle yeni line'ına ekleniyor.
                    Board.toDoLine.Remove(newCard);
                else
                    Board.doneLine.Remove(newCard);
            }
            else if(newLine == 3){
                Board.doneLine.Add(newCard);
                if(Board.toDoLine.Contains(newCard))
                    Board.toDoLine.Remove(newCard);
                else
                    Board.inProgressLine.Remove(newCard);
            }
            else{
                Board.toDoLine.Add(newCard);
                if(Board.doneLine.Contains(newCard))
                    Board.doneLine.Remove(newCard);
                else
                    Board.inProgressLine.Remove(newCard);
            }
        }
        public void lineEkle(Card newCard){                             //Sisteme eklenen kartı varsayılan olarak toDoLine listesine atıyoruz. Yani toDoLine'a ekliyoruz.
            Board.toDoLine.Add(newCard);
        }
        public void kartSil(Card card){                                 //Kart sistemden siliniyorsa boardActions.cs 'de de kendi listelerinden(toDoLine, inProgressLine, doneLine) siliniyor.
            Board.inProgressLine.Remove(card);
            Board.toDoLine.Remove(card);
            Board.doneLine.Remove(card);
        }
        public void guncelle(Card card){                                //Bir kart güncelleniyorsa CardActions tarafında ilgili kısımları güncelleniyor ve güncellenen 
            if(Board.toDoLine.Contains(card)){                          //nesne BoardActions tarafına gönderilip, toDoLine, inProgressLine, doneLine listelerinin
                Board.toDoLine.Remove(card);                            //hangisinde bulunuyorsa orada da güncellenmesi için ilk önce silinip sonra tekrar ekleniyor.
                Board.toDoLine.Add(card);
            }
            else if(Board.inProgressLine.Contains(card)){
               Board.inProgressLine.Remove(card);
               Board.inProgressLine.Add(card); 
            }
            else{
                Board.doneLine.Remove(card);
                Board.doneLine.Add(card);
            }
        }
    }
}