namespace Proje1
{
    public class RecordActions : IRecord
    {
        List<Record> recordList = new List<Record>();

        public RecordActions(){
            recordList.Add(new Record("Hidayet", "Okur", "1234"));
            recordList.Add(new Record("Mehmet", "Yıldız", "123"));
            recordList.Add(new Record("Ahmet", "Çoban", "123"));
            recordList.Add(new Record("Ayşe", "Yılmaz", "000"));
            recordList.Add(new Record("Mahmut", "Sağlam", "123"));
        }
        public void aramaYapma()
        {
            Console.Write("\n\n********************\n");
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int secim = Int32.Parse(Console.ReadLine());

            if(secim == 2){
                Console.WriteLine("Aranacak kişinin telefon numarsını giriniz");
                string numara = Console.ReadLine();
                foreach (var item in recordList)
                {
                    if(item.Numara == numara){
                        Console.WriteLine("İsim: {0} Soyisim: {1} Telefon Nuamrası: {2}", item.Isim, item.Soyisim, item.Numara);
                    }
                }
            }
            else{
                Console.WriteLine("Aranacak kişinin ismini veya soyismini giriniz");
                string isim_soyisim = Console.ReadLine();
                foreach (var item in recordList)
                {
                    if(item.Isim == isim_soyisim || item.Soyisim == isim_soyisim){
                        Console.WriteLine("İsim: {0} Soyisim: {1} Telefon Nuamrası: {2}", item.Isim, item.Soyisim, item.Numara);
                    }
                }
            }
        }

        public void kayitEkle()
        {
            Console.Write("\n\n********************\n");
            Console.WriteLine("Lütfen isim giriniz             : ");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string numara = Console.ReadLine();
            recordList.Add(new Record(isim, soyisim, numara));
            Console.Write("\n********************\n");
        }

        public void kayitGuncelle()
        {
            Console.Write("\n\n********************\n");
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string isim_soyisim = Console.ReadLine();
            foreach (var item in recordList)
            {
                if(item.Isim == isim_soyisim || item.Soyisim == isim_soyisim){
                    Console.WriteLine("{0} {1} kişisinin yeni numarasını giriniz", item.Isim, item.Soyisim);
                    string yeni_numara =  Console.ReadLine();
                    item.Numara = yeni_numara;
                    Console.WriteLine("Güncelleme işlemi başarılı");
                    Console.Write("\n********************\n");
                    break;
                }
            }
        }

        public void kayitListele()
        {
            Console.Write("\n\n********************\n");
            foreach (var item in recordList)
            {
                Console.WriteLine("İsim: "+item.Isim+ " Soyisim: " + item.Soyisim+ " Telefon Numarası: " + item.Numara);
            }
            Console.Write("\n********************\n");
        }

        public void kayitSil()
        {
            Console.Write("\n\n********************\n");
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string kayit = Console.ReadLine();
            bool kayitBulundu = false;
            foreach (var item in recordList)
            {
                if(item.Isim == kayit || item.Soyisim == kayit){
                    kayitBulundu = true;
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item.Isim);
                    string secim = Console.ReadLine();
                    if(secim == "y"){
                        recordList.RemoveAt(recordList.IndexOf(item));
                        Console.WriteLine("Silme işlemi başarılı");
                    }
                    else{
                        Console.WriteLine("Silme işlemi iptal edildi.");
                    }
                    Console.Write("\n********************\n");
                    break;
                }
            }
            if(kayitBulundu == false){
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int secim = Int32.Parse(Console.ReadLine());
                Console.Write("\n********************\n");
                if(secim == 2){
                    kayitSil();
                }
            }
        }
    }
}