using System;

namespace sinif_kavrami
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****Calisan1***");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 234415634, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("****Calisan2***");
            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("****Calisan3***");
            Calisan calisan3 = new Calisan("Zikriye","Ürkmez");
            calisan3.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyad:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);

        }
    }
    
    class Person //HackerRank //https://www.hackerrank.com/challenges/30-class-vs-instance/problem
    {
        public int age;     
        public Person(int initialAge) {
            if(initialAge>0)
            {
                this.age = initialAge;
            }
            else{
                this.age=0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }
        public void amIOld() {
            // Do some computations in here and print out the correct statement to the console 
            if(this.age<13)
            {
                Console.WriteLine("You are young.");
            }
            else if(this.age>=13 && this.age<18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else{
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses() {
            // Increment the age of the person in here
            this.age++;
        }
    }
}