namespace Proje1
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Fibonacci değerini hesaplamak istediğiniz sayiyi giriniz: ");
            Hesapla hesapla = new Hesapla();
            Console.WriteLine(hesapla.calculateFib(Int32.Parse(Console.ReadLine())));
        }
    }
    class Hesapla
    {
        public int calculateFib(int i){
            if(i == 1){
                return 1;
            }
            else if(i==2){
                return 1;
            }
            return calculateFib(i-1) + calculateFib(i-2);
        }
    }
}
