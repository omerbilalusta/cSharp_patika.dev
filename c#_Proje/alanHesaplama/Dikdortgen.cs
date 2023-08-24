namespace alanHesaplama
{
    class Dikdortgen
    {
        private double taban;
        private double derinlik;
        
        public double Taban {
            get => taban;
            set {
                if(value<0)
                    Console.WriteLine("Taban 0 den küçük olamaz");
                else
                    this.taban = value;
            }
        }

        public double Derinlik {
            get => derinlik;
            set {
                if(value<0)
                    Console.WriteLine("Derinlik 0 den küçük olamaz");
                else
                    this.derinlik = value;
            }
        }

        public Dikdortgen(double yukseklik, double taban)
        {
            if (yukseklik > 0 && taban > 0)
            {
                this.taban = taban;
                this.Derinlik = derinlik;
            }
            else
            {
                this.taban = 1;
                this.Derinlik = 1;
                Console.WriteLine("Hatalı ölçü girildi.\nTaban=1, Derinlik=1 olarak nesne oluşuturuldu.");
            }
        }
        public Dikdortgen(){
            
        }
        public void dikdortgenCevreHesapla(Dikdortgen dikdortgen){
            Console.WriteLine("Dikdörtgenin çevresi: " + (2*(dikdortgen.Taban+dikdortgen.Derinlik)));
        }
        public void dikdorgenAlanHesapla(Dikdortgen dikdortgen){
            Console.WriteLine("Dikdortgenin alanı: " + (dikdortgen.Taban*dikdortgen.Derinlik));
        }
        public void dikdorgenHacimHesapla(Dikdortgen dikdortgen){
            Console.WriteLine("Dikdortgenüç boyutlu olduğu için hacmi yoktur.\nBu cismi dikdörtgenler prizmasına dönüştürürsek, bize lütfen yükseklik bilgisi verin.");
            int yukseklik = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kürenin hacmi: " + (dikdortgen.Taban*dikdortgen.Derinlik*yukseklik));
        }
    }
}