using System.Security.Cryptography.X509Certificates;

namespace proj
{
    internal class session_05
    {
        public static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        public static void Exercise1()
        {
            int a = 3, b = 6, c = 5;
            int max = MaxOfThree(a, b, c);
            Console.WriteLine(max);
        }
        public static int MaxOfThree(int a, int b)
            {
                return a > b ? a : b;
            }
        public static int MaxOfThree(int a, int b,int c)   
            {
            return MaxOfThree(MaxOfThree(a, b), c);
            }
        
        public static void Exercise2()
        {
            Console.WriteLine("Enter the number= ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("The factorial number= ");
            int f = Factorial(n);
            Console.WriteLine($"The factorial of {n} is {f}");
        }
        public static int Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }
        public static void Exercise3()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            int d = 0;
            for (int i = 1; i <= a ; i++)
            {
                if (a % i == 0)
                {
                    d++;
                }
            }
            if (d == 2)
            {
                Console.WriteLine("The num is prime.");
            }
            else
            {
                Console.WriteLine("The num is not prime.");

            }
        }
        public  void Exercise4()
        {
            Console.WriteLine("enter the num: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //1.

            for (int i = 2; i < n; i++)
            {
                int d = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        d++;
                    }
                }
                if (d == 2)
                {
                    Console.WriteLine($"Prime num less than {n}: {i}");
                }
            }
            Console.WriteLine();
            //2.

            int b = 2;
            int count = 0;
            while (count < n)
            {
                int c = 0;
                for (int e = 1; e <= b; e++)
                {
                    if (b % e == 0)
                    {
                        c++;
                    }
                }
                if (c == 2)
                {
                    Console.WriteLine($"The prime number:{b}");
                    count++;
                }
                b++;
            }
        }
        public  void Exercise5()
        {
            Console.WriteLine("enter a number: ");
            int n = int.Parse(Console.ReadLine());
            if (n<1)
            {
                Console.WriteLine("Not perfect.");
                return;
            }
            int sum = 0;
            for (int i = 1;i<=n/2;i++)
            {
                if(n%i == 0)
                {
                    sum+=i;
                }              
            }
            if(sum==n)
            {
                Console.WriteLine("This is perfect num.");
            }
            else 
            { 
                Console.WriteLine("Not perfect.");
            }
        }
        public  void Exercise6()
        {

        }
    }
}
