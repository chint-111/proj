

namespace proj
{
    internal class Session_03
    {
        public static void Main(string[] args)
        {
            //Ex_01();
            //Ex_02();
            Ex_03();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        public static void Ex_01()
        {
            Console.Write("Enter the celsius degree c= ");
            double c=double.Parse(Console.ReadLine());
            double k = c + 273;
            double f = c * 18 / 10 + 32;
            Console.WriteLine($"kelvin degree = {k}");
            Console.WriteLine($"fahrenheit degree = {f}");
        }
        public static void Ex_02()
        {
            Console.Write("enter the radius r= ");
            double r= double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * r * r;
            double volumn = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"surface = {surface}");
            Console.WriteLine($"volumn = {volumn}");
        }
        public static void Ex_03()
        {
            double a= double.Parse(Console.ReadLine());
            double b= double.Parse(Console.ReadLine());
            double add = a + b;
            Console.WriteLine($"{a}+{b}={add}");
            double sub= a - b;
            Console.WriteLine($"{a}- {b}= {sub}");
            double mul=a * b;
            Console.WriteLine($"{a}* {b} ={sub}");
            double div = a / b;
            Console.WriteLine($"{a}/ {b}={div}");
            double mod = a % b;
            Console.WriteLine($"{a}%{b}={mod}");
        }
    }
}
