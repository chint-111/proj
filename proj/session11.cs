using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace proj
{
    internal class session11
    {
        static void Main11(string[] args)
        {
            while (true) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. check triangle.");
            Console.WriteLine("2.Average and sum of 10 integers.");
            Console.WriteLine("3.Multiplication of a given integer.");
            Console.WriteLine("4.Display patterns like triangle.");
            Console.WriteLine("5.Harmonic series and sum ");
            Console.WriteLine("6.Find perfect number.");
            Console.WriteLine("7.Find Prime number.");
            Console.WriteLine("8.Exit.");
            Console.WriteLine("Enter the question (1->8):");
            int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter 3 sides of a triangle:");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        if (a + b > c && a + c > b && b + c > a)
                        {
                            if (a == b && b == c)
                                Console.WriteLine("This is Equi");
                            else if (a == b || b == c || a == c)
                                Console.WriteLine("This is Iso");
                            else Console.WriteLine("This is Sca");
                        }
                        else Console.WriteLine("This is not valid triangle.");
                        break;
                    case 2:
                        Console.WriteLine("Enter 10 numbers:");
                        double sum = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Enter the number {i + 1}:");
                            int n = int.Parse(Console.ReadLine());
                            sum += n;
                        }
                        double average = sum / 10;
                        Console.WriteLine($"Average result: {average}");
                        break;
                    case 3:
                        Console.WriteLine("Enter a number:");
                        int num = int.Parse(Console.ReadLine());
                        int res = 1;
                        for (int i = 1; i <= 10; i++)
                        {
                            res = num * i;
                            Console.WriteLine($"{num}*{i}={res}");
                        }
                        break;
                    case 4:

                    case 8:
                        return;
                    default:
                        Console.WriteLine("Enter 1-8");
                        break;
                }
            }
        }
    }
}
