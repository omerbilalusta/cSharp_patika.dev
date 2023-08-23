namespace drawCircle
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            Console.Write("Dairenin yarıçapını girin: ");
            int radius = Int32.Parse(Console.ReadLine());
            Calculate calculate = new Calculate();
            calculate.DrawCircle(radius);
        }

    }
    class Calculate
    {
        public void DrawCircle(int radius)
        {
            for (int y = -(int)radius; y <= (int)radius; y++)
            {
                for (int x = -(int)radius; x <= (int)radius; x++)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}