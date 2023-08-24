namespace karakterDegistirme
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Cümle giriniz: ");
            string input = Console.ReadLine();
            char[] array = new char[10];
            List<string> list = new List<string>();
            string word="";
            foreach (var item in input.Split(' '))
            {
                array = item.ToString().ToCharArray();
                char keep = array.Last();
                array[array.Count()-1] = array.First();
                array[0] = keep;
                foreach (var item2 in array)
                {
                    word+=item2;
                }
                list.Add(word);
                word="";
            }
            list.ForEach(x=> Console.Write(x+" "));
        }
    }
}