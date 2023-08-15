using System;

namespace cdictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            //System.Collention.Generic
            Dictionary<int, string>  kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10,"Ayşe Yılmaz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(20, "Özcan Coşar");
            
            Console.WriteLine("****** Elemanlara erişim *****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("*** Count ****");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("**** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));
        
            //Remove
            Console.WriteLine("***Remove****");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value);
            }
            
            //Keys
            //Values
            Console.WriteLine("****Keys Values****");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
    class HackerRank // https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
    {
        static void Main(String[] args) {
        int count = Convert.ToInt32(Console.ReadLine());
        string[] record = new string[2];
        Dictionary<string, int> book = new Dictionary<string, int>();
        
        for(int i=0;i<count*2;i+=2)
        {
            record = Console.ReadLine().Split(' ');
            book.Add(record[0], Convert.ToInt32(record[1]));
        }
        
        string search;
        while(true)
        {
            search = Console.ReadLine();
            if(string.IsNullOrEmpty(search))
            {
                break;
            }
            if(book.ContainsKey(search))
            {
                Console.WriteLine(search+"="+book[search]);
            }
            else{
                Console.WriteLine("Not found");
            }
        }
    }
    }
}