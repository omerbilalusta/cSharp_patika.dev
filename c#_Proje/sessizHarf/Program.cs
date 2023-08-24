namespace sessizHarf
{
    class Program
    {
        static void Main(string[] args){
            char [] sesliHarf = new char[]{'a','e','ı','i','o','ö','u','ü','A','E','I','İ','O','Ö','U','Ü'};
            Console.WriteLine("Cümle giriniz: ");
            string input = Console.ReadLine();
            bool triger = false, triger2 = false;
            char keep='0';
            foreach (var item in input.Split())
            {
                triger = false;
                foreach (var item2 in item.ToCharArray())
                {
                    if(!sesliHarf.Contains(keep) && !sesliHarf.Contains(item2)){
                        if(triger2==true){
                            Console.Write("True ");
                            triger = true;
                            triger2 = false;
                            break;
                        }
                        triger2=true;
                        keep = item2;
                    }
                    else
                        triger2=false;
                }
                if(triger == false)
                    Console.Write("False ");
            }
        }
    }
}