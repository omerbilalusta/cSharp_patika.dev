namespace reverseString
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Cümle giriniz.");
            string input = Console.ReadLine();
            foreach (var item in input.Split(' '))
            {
                foreach (var reversedItem in item.Reverse())
                {
                    Console.Write(reversedItem);
                }
                Console.Write(" ");
            }
        }
    }
}