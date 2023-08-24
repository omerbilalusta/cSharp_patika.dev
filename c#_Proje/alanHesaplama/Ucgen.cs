namespace alanHesaplama
{
    class Ucgen
    {
        private double kenar1;
        private double kenar2;
        private int aci;
        

        public double Kenar1 {
            get => kenar1;
            set {
                if(value<0)
                    Console.WriteLine("Kenar 0 den küçük olamaz");
                else
                    this.kenar1 = value;
            }
        }
        public double Kenar2 {
            get => kenar2;
            set {
                if(value<0)
                    Console.WriteLine("Kenar 0 den küçük olamaz");
                else
                    this.kenar2 = value;
            }
        }
        public int Aci {
            get => aci;
            set {
                if(value<0)
                    Console.WriteLine("Aci 0 den küçük olamaz");
                else
                    this.aci = value;
            }
        }

        public Ucgen(double kenar1, double kenar2, int aci){
            if(kenar1>0 && kenar2>0 && aci>0){
                this.kenar1 = kenar1;
                this.kenar2 = kenar2;
                this.aci = aci;
            }
            else{
                this.kenar2=3;
                this.kenar1=4;
                this.aci = 90;
                Console.WriteLine("Hatalı ölçü girildi.\n3-4-5 üçgeni varsayılan olara oluşturuldu.");
            }
        }
        public Ucgen(){
            
        }
        public void ucgenCevreHesapla(Ucgen ucgen){
            int kenar3 = (int)Math.Sqrt(Math.Pow(ucgen.kenar1,2)+Math.Pow(ucgen.kenar2,2)-2*ucgen.kenar1*ucgen.kenar2*Math.Cos(aci)); //Kosinüs teorimi ile üçüncü kenar hesaplandı.
            Console.WriteLine("Ucgenin çevresi: " + (ucgen.kenar1+ucgen.kenar2+kenar3));
        }
        public void ucgenAlanHesapla(Ucgen ucgen){
            Console.WriteLine("Ucgenin alanı: " + (0.5*ucgen.kenar1*ucgen.kenar2*Math.Sin(ucgen.aci))); //Sinüs teorimi ile alan hesaplandı
        }
        public void ucgenHacimHesapla(Ucgen ucgen){
            Console.WriteLine("Kenar uzunluklarını verdiğiniz yüze göre üçgenin yüksekliğini veriniz.");
            int yukseklik = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ucgenin hacim hesapl: " + (0.5*ucgen.kenar1*ucgen.kenar2*ucgen.aci)*yukseklik); // Sinüs teorimi ile bir yüzün alınını hesapladık ve bu yüze ait yükseklik ile hacmi hesapladık.
        }
    }
}