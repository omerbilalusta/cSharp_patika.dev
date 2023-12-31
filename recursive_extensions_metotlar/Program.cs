﻿using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif- Öz yinelemeli
            //3^4
            int result=1;
            for (int i = 1; i < 5; i++)
            {
                result=result*3;
            }
            Console.WriteLine(result);
            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));
            
            // Extension Metotlar
            string ifade="Hakan Yılmaz";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi={9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();
            
            int sayi =5;
            Console.WriteLine(sayi.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstCharacter());            
        }
        
        // HackerRank https://www.hackerrank.com/challenges/30-recursion/problem
        public static int factorial(int n)
            {
                if(n==1)
                {
                    return n;
                }
                return factorial(n-1)*n;
            }
    }
    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return Expo(sayi, üs-1)*sayi;
        }
        //Expo(3,4)

    }
    
    public static class Extension
    {
        public static bool CheckSpace(this string param){
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param){
            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        }
        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param){
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param){
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumber(this int param){
            return param%2==0;
        }
        public static string GetFirstCharacter(this string param){
            return param.Substring(0,1);
        }
    }
    
}


