namespace integerIkililerinToplami
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Boşluk bırakarak değerleri giriniz: ");
            string input = Console.ReadLine().ToString();
            int counter = 0, last=0, itemm;
            double toplam;
            foreach (var item in input)
            {
                if(item != ' '){
                    counter++;
                    if(counter == 2){
                        itemm=Int32.Parse(item.ToString());
                        toplam = last + itemm;
                        if(last == itemm){
                            Console.Write(Math.Pow(last*2,2)+" ");
                        }
                            
                        else
                            Console.Write(toplam+" ");
                        counter=0;
                        last = 0;
                    }
                    last = Int32.Parse(item.ToString());
                }
            }
        }
    }
}