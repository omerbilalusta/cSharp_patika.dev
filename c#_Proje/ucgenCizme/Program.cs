namespace drawTriangle
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            Console.WriteLine("Çizilecek üçgen için boyut bilgisi giriniz");
            int height = Int32.Parse(Console.ReadLine());
            Calculate calculate = new Calculate();
            calculate.drawTriangle(height);


        }
    }
    class Calculate
    {
        public void drawTriangle(int height){ // içi dolu üçgen çizme
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine("");
                for (int j=height; j>i ; j--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < (i*2)-1; x++)
                {
                    Console.Write("*");
                }
            }
        }
        public void drawTriangleEmpty(int height){ //içi boş üçgen çizme
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine("");
                for (int j=height; j>i ; j--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < (i*2)-1; x++)
                {
                    if(i==height){
                        Console.Write("*");
                    }
                    else if(x==0 || x == (i*2)-2){
                        Console.Write("*");
                    }
                    else{
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
