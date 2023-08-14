using System;

namespace cSharpExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2= "CSharp";
            //Length
            Console.WriteLine(degisken.Length);

            //ToUppper, ToLower

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("asd"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));
            
            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+ degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

            //HackerRank https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/problem

            string S = Console.ReadLine();
            try{
                Console.WriteLine(Int32.Parse(S));
            }
            catch(SystemException ex)
            {
                Console.WriteLine("Bad String");
            }

            //HackerRank https://www.hackerrank.com/challenges/30-review-loop/problem
            int numberOfTestCases=Int32.Parse(Console.ReadLine());
            List<string> s = new List<string>();
            List<char> odd = new List<char>();
            List<char> even = new List<char>();
            for(int i=0;i<numberOfTestCases;i++)
            {
                s.Add(Console.ReadLine().ToString());
            }
            for(int i=0;i<s.Count;i++)
            {
                for(int j=0;j<s[i].Length;j++)
                {
                    if(j%2==1)
                    {
                        odd.Add(s[i][j]);
                    }
                    else if(j%2==0)
                    {
                        even.Add(s[i][j]);
                    }
                }
                for(int k=0; k<even.Count; k++)
                {
                    if(k==0)
                    {
                        Console.Write(even[k]);
                    }
                    else{
                        Console.Write(even[k]);
                    }
                    
                }
                Console.Write(" ");
                for(int k=0; k<odd.Count; k++)
                {
                    if(k==0)
                    {
                        Console.Write(odd[k]);
                    }
                    else{
                        Console.Write(odd[k]);
                    }
                    
                }
                Console.WriteLine("");
                odd.Clear();
                even.Clear();
            }
        }
    }
}