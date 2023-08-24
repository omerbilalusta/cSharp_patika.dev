namespace alanHesaplama
{
    class Daire
    {
        private double yariCap;
        

        public double YariCap {
            get => yariCap;
            set {
                if(value<0)
                    Console.WriteLine("Yükseklik 0 den küçük olamaz");
                else
                    this.yariCap = value;
            }
        }

        public Daire(double yariCap){
            if(yariCap>0){
                this.yariCap = yariCap;
            }
            else{
                this.yariCap=1;
                Console.WriteLine("Hatalı ölçü girildi.\nYarıçap=1 olarak nesne oluşuturuldu.");
            }
        }
        public Daire(){
            
        }
        public void daireCevreHesapla(Daire daire){
            Console.WriteLine("Dairenin çevresi: " + (2*Math.PI*daire.YariCap));
        }
        public void daireAlanHesapla(Daire daire){
            Console.WriteLine("Dairenin alanı: " + (Math.PI*Math.Pow(daire.YariCap,2)));
        }
        public void daireHacimHesapla(Daire daire){
            Console.WriteLine("Dairenin iki boyutlu olduğu için hacmi hesaplanamaz.\nBu cismi küre sayarsak hacmi: " + Math.PI*Math.Pow(daire.YariCap,3)*4/3);
        }
    }
}