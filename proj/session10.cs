using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session10
    {
        static void Main10(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Sum");
                Console.WriteLine("2.Swap");
                Console.WriteLine("3.Times");
                Console.WriteLine("4.Convert feet to meter");
                Console.WriteLine("5.Find size of data types");
                Console.WriteLine("6.Convert C->F");
                Console.WriteLine("7.Print ACSii value");
                Console.WriteLine("8.Area of circle");
                Console.WriteLine("9.area of square.");
                Console.WriteLine("10. Convert days to years, weeks, and days.");
                Console.WriteLine("11.Exit");
                Console.WriteLine("Enter the question:");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter 1st num:");
                        int a=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2nd num:");
                        int b=int.Parse(Console.ReadLine());
                        int result=Sum(a,b);
                        Console.WriteLine($"{a}+{b}={result}.");
                        break;
                    case 2:
                        Console.WriteLine("Enter 1st num:");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2nd num:");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("After swapping:");
                        Swap( ref n1,ref n2);
                        Console.WriteLine($"1st num: {n1},2nd num :{n2}.");
                        break;
                    case 3:
                        Console.WriteLine("Enter 1st num:");
                        double a1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2nd num:");
                        double a2 = double.Parse(Console.ReadLine());
                        double mul=Multiply(a1,a2);
                        Console.WriteLine($"{a1}*{a2}={mul}.");
                        break ;
                    case 4:
                        Console.WriteLine("Enter feet:");
                        double feet=double.Parse(Console.ReadLine());  
                        double meter=ConvertMeter(feet);
                        Console.WriteLine($"Meter={meter}.");
                        break;
                    case 5:
                        Console.WriteLine("int" +sizeof(int)+"bytes");
                        break;
                    case 6:
                        Console.WriteLine("Choose 6a or 6b:");
                        Console.WriteLine("61.C->F");
                        Console.WriteLine("62.F->C");
                        Console.WriteLine("Enter:");
                        int option=int.Parse(Console.ReadLine());

                        if (option == 61)
                        {
                            Console.WriteLine("Enter C");
                            double cel = double.Parse(Console.ReadLine());
                            double fah = (cel * 9 / 5) + 32;
                            Console.WriteLine($"Fah={fah}");
                        }
                        else if (option == 62)
                        {
                            Console.WriteLine("ENter F=");
                            double f = double.Parse(Console.ReadLine());
                            double c = (f - 32) * 5 / 9;
                            Console.WriteLine($"Cel={c}.");
                        } 
                        else Console.WriteLine("Pleaze enter 61 or 62.");
                        break;
                    case 7:
                        Console.WriteLine("Enter a character:");
                        char input = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        int AsciiValue = Convert.ToInt32(input);
                        Console.WriteLine($"{input}'s Ascii value is {AsciiValue}");

                        break;
                    case 8:
                        Console.WriteLine("Enter r=");
                        double r=double.Parse(Console.ReadLine());
                        double area = r * r * Math.PI;
                        Console.WriteLine();
                        Console.WriteLine(area);
                        break;
                    case 9:
                        Console.WriteLine("enter side=");
                        double side=double.Parse(Console.ReadLine());
                        double areaS= side * side;
                        Console.WriteLine();
                        Console.WriteLine(areaS);
                        break;
                    case 10:
                        Console.WriteLine("Enter days:");
                        int days=int.Parse(Console.ReadLine());
                        int year = days / 365;
                        int week = days / 7;
                        int day= days % 7;
                        Console.WriteLine($"{days} equals {year} year, {week} weeks and {day} day.");
                        break;
                    case 11:
                        return;
                    default:
                        Console.WriteLine("enter 1->11.");
                        break ;
                }



            }            
        }
        static int Sum(int a,int b)
        {
            return a + b;
        }
        static void  Swap(ref int n1,ref int n2)
        {
            (n1, n2) = (n2, n1);
        }
        static double Multiply(double a1,double a2)
        {
            return a1*a2;
        }
        static double ConvertMeter(double feet)
        {
            return feet*0.32;
        }
    }
}
