namespace votingUygulamasi
{
    class Program
    {
        static int Main(string[] args){
            Console.Clear();
            Category korkuKategori = new Category(1,"korku");
            Category aksiyonKategori = new Category(2,"aksiyon");
            Category animasyonKategori = new Category(3,"animasyon");
            Category polisiyeKategori = new Category(4,"polisiye");
            Category bilimKurguKategori = new Category(5,"bilimKurgu");
            
            categoryManagement.categoryCreate(korkuKategori, aksiyonKategori, animasyonKategori, polisiyeKategori, bilimKurguKategori);
            List<user> userList = new List<user>();
            userList.Add(new user(1,"Omer","me@omer.com"));
            userList.Add(new user(2, "Yavuz","coban@hotmail.com"));
            userList.Add(new user(3, "Ahmet", "ahmet@coban.com"));

            login:
            Console.WriteLine("Giriş yapmak üzere email adresini giriniz.");
            string input_email = Console.ReadLine();
            bool logInSuccess = false;
            foreach (var item in userList)
            {
                if(item.E_mail==input_email){
                    logInSuccess = true;
                    break;
                }
            }
            if(logInSuccess == false){
                Console.WriteLine("\nÜyeliğiniz bulunamamıtır. Üye olmak için lütfen sırasıyla isim ve Email giriniz.");
                string[] registerInput = Console.ReadLine().Split(' ');
                userList.Add(new user(userList.Count-1, registerInput[0], registerInput[1]));
                Console.WriteLine("Kayıt Başarılı.\n{0} Hoşgeldiniz!\n", registerInput[0]);
            }
            int voteCount = 0;
            do
            {
                Console.WriteLine("\nOy kullanmak istediğiniz kategoriyi seçinin. Sistemden çıkmak için 9'a basınız.");
                Console.WriteLine("Korku Kategorisi********************(1)");
                Console.WriteLine("Aksiyon Kategorisi******************(2)");
                Console.WriteLine("Animasyon Kategorisi****************(3)");
                Console.WriteLine("Polisiye Kategorisi*****************(4)");
                Console.WriteLine("Bilim Kurgu Kategorisi**************(5)");
                int choice = Int32.Parse(Console.ReadLine());
                if(choice == 1)
                    categoryManagement.vote(korkuKategori);
                else if(choice == 2)
                    categoryManagement.vote(aksiyonKategori);
                else if(choice == 3)
                    categoryManagement.vote(animasyonKategori);
                else if(choice == 4)
                    categoryManagement.vote(polisiyeKategori);
                else if(choice == 5)
                    categoryManagement.vote(bilimKurguKategori);
                else
                    break;
                voteCount++;

            } while (true);
            if(Console.ReadLine() == "0"){
                Console.WriteLine("\n\n******* Oylama Sonucu ********");
                categoryManagement.voteCount(korkuKategori, voteCount);
                categoryManagement.voteCount(aksiyonKategori, voteCount);
                categoryManagement.voteCount(animasyonKategori, voteCount);
                categoryManagement.voteCount(polisiyeKategori, voteCount);
                categoryManagement.voteCount(bilimKurguKategori, voteCount);
                return 0;
            }
            goto login;
        }
    }
}