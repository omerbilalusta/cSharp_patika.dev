namespace votingUygulamasi
{
    class Category
    {
        public int id;
        public string categoryName;
        public List<movie> list = new List<movie>();
        public Category(int id, string categoryName)
        {
            this.id = id;
            this.categoryName = categoryName;
        }
        
    }
    static class categoryManagement
    {
        public static void categoryCreate(Category korkuKategori, Category aksiyonKategori, Category animasyonKategori, Category polisiyeKategori, Category bilimKurguKategori){
            korkuKategori.list.Add(new movie(1,"Kutsal Damacana"));
            korkuKategori.list.Add(new movie(2,"Dabbe"));
            korkuKategori.list.Add(new movie(3,"Chucky"));
            aksiyonKategori.list.Add(new movie(4,"Görevimiz Tehlike"));
            aksiyonKategori.list.Add(new movie(5,"Top Gun: Maverick"));
            aksiyonKategori.list.Add(new movie(6,"Nefes: Vatan Sağolsun"));
            animasyonKategori.list.Add(new movie(7,"Transformes"));
            animasyonKategori.list.Add(new movie(8,"Arabalar"));
            polisiyeKategori.list.Add(new movie(9,"Arka Sokaklar"));
            bilimKurguKategori.list.Add(new movie(10,"Arog"));
            bilimKurguKategori.list.Add(new movie(11, "Interstealler"));
        }
        public static void vote(Category category){
            category.list.ForEach(x=> Console.WriteLine(x.MovieName + " (" + x.MovieId + ")"));
            Console.WriteLine("Oy vermek istediğiniz filmin ID'sini giriniz");
            int choice = Int32.Parse(Console.ReadLine());
            foreach (var item in category.list)
            {
                if(choice == item.MovieId)
                    item.vote();
            }
            Console.WriteLine("Verdiğiniz oy başarıyla kaydedilmiştir.\n");
        }
        public static void voteCount(Category category, int voteCount){
            double oy;
            category.list.ForEach(x=> Console.WriteLine("{0} : {1} oy -- %{2}", x.MovieName, x.VoteCount, (double)x.VoteCount/voteCount*100));
        }
    }
}