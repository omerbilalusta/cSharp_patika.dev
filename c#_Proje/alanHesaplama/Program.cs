namespace alanHesaplama
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            Console.WriteLine("Alanı hesaplanacak şekli seçiniz: ");
            Console.WriteLine("Üçgen ************************(1)");
            Console.WriteLine("Dikdörtgen *******************(2)");
            Console.WriteLine("Daire ************************(3)");
            int secim;
            Int32.TryParse(Console.ReadLine(), out secim);
            Ucgen ucgen = new Ucgen();
            Dikdortgen dikdortgen = new Dikdortgen();
            Daire daire = new Daire();
            try
            {
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Sırasyıla yükselik, taban ölçüsü ve bu kenarlara ait açıyı giriniz giriniz.");
                        double yukseklik = Int32.Parse(Console.ReadLine());
                        double taban = Int32.Parse(Console.ReadLine());
                        int aci = Int32.Parse(Console.ReadLine());
                        ucgen.Kenar1=yukseklik;
                        ucgen.Kenar2=taban;
                        ucgen.Aci = aci;
                        break;
                    case 2:
                        Console.WriteLine("Sırasyıla yükselik ve taban ölçüsü giriniz.");
                        double derinlik = Int32.Parse(Console.ReadLine());
                        double taban2 = Int32.Parse(Console.ReadLine());
                        dikdortgen.Derinlik = derinlik;
                        dikdortgen.Taban=taban2;
                        break;
                    case 3:
                        Console.WriteLine("Yarıçap giriniz.");
                        double yariCap = Int32.Parse(Console.ReadLine());
                        daire.YariCap = yariCap;
                        break;
                    default:
                        break;
                }
                
            }
            catch (System.Exception)
            {
                Console.WriteLine("Hatalı seçim!");
            }
            do
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
                Console.WriteLine("Çevre Hesaplama ******************(1)");
                Console.WriteLine("Alan Hesaplama  ******************(2)");
                Console.WriteLine("Hacim Hesaplama ******************(3)");
                try
                {
                    int secim2;
                    Int32.TryParse(Console.ReadLine(), out secim2);
                    switch (secim2)
                    {
                        case 1:
                            if(secim==1)
                                ucgen.ucgenCevreHesapla(ucgen);
                            else if(secim==2)
                                dikdortgen.dikdortgenCevreHesapla(dikdortgen);
                            else
                                daire.daireCevreHesapla(daire);
                            break;
                        case 2:
                            if(secim==1)
                                ucgen.ucgenAlanHesapla(ucgen);
                            else if(secim==2)
                                dikdortgen.dikdorgenAlanHesapla(dikdortgen);
                            else
                                daire.daireAlanHesapla(daire);
                            break;
                        case 3:
                            if(secim==1)
                                ucgen.ucgenHacimHesapla(ucgen);
                            else if(secim==2)
                                dikdortgen.dikdorgenHacimHesapla(dikdortgen);
                            else
                                daire.daireHacimHesapla(daire);
                            break;
                        default:
                            break;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Hatalı seçim!");
                }
            } while (true);
            
        }
    }
}