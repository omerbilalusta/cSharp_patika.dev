namespace Proje1
{
    class Record
    {
        private string isim;
        private string soyisim;
        private string numara;

        public Record (string isim, string soyisim, string numara){
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Numara = numara;
        }

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Numara { get => numara; set => numara = value; }
    }
}