using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace proj
{
    internal class session_05
    {
        public static void Main5(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
           //Exercise4();
            Exercise5();
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
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            bool Prime = isPrime(n);
            Console.WriteLine(Prime?$"{n} is prime":$"{n}is not prime");
            
        }
        public static bool isPrime(int n)
        {
            if(n<=1)
                return false;
            if(n==2||n==3)
                return true;
            if(n%2==0||n%3==0)
                return false;
            for(int i=5;i<=Math.Sqrt(n);i+=2)
            {
                if (n%i==0)
                    return false ;
            }
            return true;
        }
        public static void Exercise4()
        {
            Console.Write("Enter the number: ");
            int n=int.Parse(Console.ReadLine());
            bool Prime= isPr(n);
            PrimeLess(n);
            PrintFirstPrime(n);
        }
        public static bool isPr(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2 || n == 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;
            for (int i = 5; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void PrimeLess(int n)
        {
            Console.WriteLine($"Prime number less than {n}: ");
            for (int i=2;i<=n;i++)
            {
                if(isPr(i))
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
        public static void PrintFirstPrime(int n)
        {
            Console.WriteLine($"First {n} prime numbers");
            int c = 0;
            int a = 2;
            while(c<n)
            {
                if(isPr(n))
                {
                    Console.Write(a+" ");
                    c++;
                }
                a++;
            }
        }
        

        public static void Exercise5()
        {
            Console.WriteLine("enter a number: ");
            int n = int.Parse(Console.ReadLine());
            bool Perfect = isPerfect(n);
            PrintAllPerfectNumber();
        }
        public static bool isPerfect(int n)
        {
            int s = 0;
            for (int i = 1;i<=n/2;i++)
            {
                if (n%i==0)
                {
                    s += i;
                }
            }
            if (s==n) 
            return true;
            else return false;  
        }
        public static void PrintAllPerfectNumber()
        {
            Console.WriteLine("All perfect number less than 1000: ");

            for (int a = 6; a < 1000; a++)
            {
                if (isPerfect(a))
                {
                    Console.Write(a+" ");
                }
            }
            Console.WriteLine();

        }
        public  void Exercise6()
        {

        }
    }
}
