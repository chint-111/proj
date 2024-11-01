namespace proj
{
    internal class session_05
    {
        public static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        public static void Exercise1()
        {
            Console.WriteLine("Enter 3 number: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = Math.Max(a, Math.Max(b, c);
            Console.WriteLine($"The max num: {d}");
        }
        public static void Exercise2()
        {
            Console.Write("Enter a non-negative integer: ");
            int a=int.Parse(Console.ReadLine());
            int f = 1;
            if (a>=0)
            {
                for(int i=1; i<=a; i++)
                {
                    f *= i;
                }

            }
            else
            {
                return a;
            }
        }

    }
}
