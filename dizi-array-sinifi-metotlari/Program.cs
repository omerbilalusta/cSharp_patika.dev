using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayiDizisi={23,12,4,86,72,3,11,17};
            Console.WriteLine("*** Sırasız Dizi *****");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            //Sort
            Console.WriteLine("**** Sıralı Dizi ****");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            
            //Clear
            Console.WriteLine("*** Array Clear ***");
            Array.Clear(sayiDizisi,2,2);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Reverse
            Console.WriteLine("*** Reverse array ***");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //IndexOf
            Console.WriteLine("*** IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("*** Resize array ***");
            Array.Resize<int>(ref sayiDizisi, 12);
            sayiDizisi[8]=99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            
            
        }
        //HackerRank  https://www.hackerrank.com/challenges/birthday-cake-candles/problem
        public static int birthdayCakeCandles(List<int> candles)
        {
            int tallest = 0;
            int count = 0;
            foreach(var item in candles)
            {
                if(item >= tallest)
                {
                    tallest = item;
                }
                
            }
            foreach(var item in candles)
            {
                if(item == tallest)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
            
        }

        //HackerRank https://www.hackerrank.com/challenges/simple-array-sum/problem
        public static int simpleArraySum(List<int> ar)
        {
            int total=0;
            foreach(var item in ar)
            {
                total+=item;
            }
            return total;
        }

        //HackerRank https://www.hackerrank.com/challenges/30-arrays/problem
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            arr.Reverse();
            foreach(var item in arr)
            {
                Console.Write(item+" ");
            }
        }

        //HackerRank https://www.hackerrank.com/challenges/a-very-big-sum/problem
        public static long aVeryBigSum(List<long> ar)
        {
            long total =0;
            foreach(var item in ar)
            {
                total+=item;
            }
            return total;
        }

        //HackerRank https://www.hackerrank.com/challenges/compare-the-triplets/problem
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int a_sPoint=0;
            int b_sPoint=0;
            int lenght=a.Count();
            for(int i=0;i<lenght;i++)
            {
                if(a[i]>b[i])
                {
                    a_sPoint++;
                }
                else if(a[i]<b[i])
                {
                    b_sPoint++;
                }
            }
            List<int> result = new List<int>();
            result.Add(a_sPoint);
            result.Add(b_sPoint);
            return result;
        }

        //HackerRank https://www.hackerrank.com/challenges/30-sorting/problem

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int pas=0;
            int swapCounter=0;
            for(int i=0;i<a.Count();i++)
            {
                for(int j=0; j<a.Count()-1; j++)
                {
                    if(a[j]>a[j+1])
                    {
                        pas = a[j+1];
                        a[j+1]=a[j];
                        a[j]=pas;
                        swapCounter++;
                    }
                }
            }
            Console.WriteLine("Array is sorted in "+ swapCounter +" swaps.");
            Console.WriteLine("First Element: "+a[0]);
            Console.WriteLine("Last Element: "+a[a.Count()-1]);
        }

        //HackerRank https://www.hackerrank.com/challenges/migratory-birds/problem
        //Üstteki cevap daha genel bir cevap, alttaki cevap ise soruya özel çünkü üstteki cevapta
        //kuş türünün sayısı belli değilken çözülmüştür ancak alttakinde beş adet kuş türü olduğu bilinerek çözülmüştür.
        //Üstteki cevap normal olarak daha fazla zaman almaktadır ancak daha genel olarak uygulanabilecek bir cevaptır.
        public static int migratoryBirds(List<int> arr)
        {
            int counter=0;
            int counter2=0;
            int itemNumber=0;
            foreach(var item in arr)
            {
                foreach(var item2 in arr)
                {
                    if(item==item2)
                    {
                        counter++;
                    }
                    if(counter>counter2)
                    {
                        counter2=counter;
                        itemNumber=item;
                    }
                }
                counter=0;
            }
            return itemNumber;
        }
        public static int migratoryBirds(List<int> arr)
        {
            int[] type= new int[5]{0,0,0,0,0};
            foreach(var item in arr)
            {
                if(item==1)
                {
                    type[0]++;
                }
                else if(item==2)
                {
                    type[1]++;
                }
                else if(item==3)
                {
                    type[2]++;
                }
                else if(item==4)
                {
                    type[3]++;
                }
                else if(item==5)
                {
                    type[4]++;
                }
            }
            return Array.IndexOf(type, type.Max())+1;
        }
    }
}