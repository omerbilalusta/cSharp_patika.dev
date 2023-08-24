namespace mutlakKareAlma
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Değer giriniz");
            string input = Console.ReadLine(), keep="";
            List<int> list = new List<int>();
            string [] array = input.Split(' ');
            
            
            int smalls=0;
            double bigs=0; 
            foreach (var item in array)
            {
                if(Int32.Parse(item) > 67)
                    bigs += Math.Pow((Int32.Parse(item)-67),2);
                else
                    smalls += 67 - Int32.Parse(item);
            }
            Console.WriteLine("Büyükler: {1} Küçükler: {0}", bigs, smalls);
        }
    }
}