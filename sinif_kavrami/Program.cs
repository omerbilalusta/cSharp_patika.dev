using System;

namespace sinif_kavrami
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=23415634;
            calisan1.Departman="İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            
            Console.WriteLine("*******");
            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

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