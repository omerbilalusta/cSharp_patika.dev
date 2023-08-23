namespace Algoritma
{
    class Program
    {
        static void Main(string[] args){                                //input, "algoritma,2 algoritma5, algoritma3" şeklinde olabilir.
            Console.WriteLine("Kelime ve sayı giriniz: ");
            string input = Console.ReadLine();
            
            List<string> list = new List<string>();
            string[] stringArray = new string[10];
            char[] charArray = new char[10];

            foreach (var item in input.Split(' '))
            {
                stringArray = item.Split(',');
                int index = Int32.Parse(stringArray[1]);
                charArray = stringArray[0].ToCharArray();
                list = charArray.Select(x=> x.ToString()).ToList();
                if(index < list.Count()){
                    list.RemoveAt(index);
                }
                list.ForEach(x=> Console.Write(x));
                Console.WriteLine();
            }
        }
    }
}