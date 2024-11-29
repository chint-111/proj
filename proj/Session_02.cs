using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class Session_02
    {
        public static void Main2(string[] args)
        {
            //Question_01();
            Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            //Question_10();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }
        ///<Summary>
        ///.to Add/Sum 2 numbers.
        ///</Summary>
        public static void Question_01()
        {
            Console.Write("Enter the first number a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number b=");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;
            Console.WriteLine($" {a} + {b} = {sum}");
            Console.WriteLine($"{a} *{b} = {product}");
            Console.ReadKey();
        }
        /// <summary>
        /// to Swap Values of Two Variables.
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Enter the first variable a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second variable b=");
            int b = int.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine($"The first variable after swaping: {a}");
            Console.WriteLine($"The second variable after swaping: {b}");
            Console.ReadKey();
        }
        /// <summary>
        /// . to Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter the first number a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number b=");
            double b = double.Parse(Console.ReadLine());
            double product = a * b;
            Console.WriteLine($" {a} * {b} = {product} ");
            Console.ReadKey();
        }
        /// <summary>
        /// to convert feet to meter
        /// </summary>
        public static void Question_04()
        {
            Console.Write("Enter the number of feet a=");
            double a = double.Parse(Console.ReadLine());
            double b = a * 0.3048;
            Console.WriteLine($"{a} feet is equal to {b} meters");
        }
        /// <summary>
        /// to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Enter the temperature (e.g.,100C or 212F): ");
            string tem = Console.ReadLine().Trim();
            if (tem.EndsWith("C", StringComparison.OrdinalIgnoreCase))
            {
                double c = double.Parse(tem[0..^1]);
                double f = (c * 9 / 5) + 32;
                Console.WriteLine($" {c} celsius degree is qual to {f} fahrenheit degree");
            }
            else if (tem.EndsWith("F", StringComparison.OrdinalIgnoreCase))
            {
                double f = double.Parse(tem[0..^1]);
                double c = (f - 32) * 5 / 9;
                Console.WriteLine($"{f} fahrenheit degree is equal to {c} celsius degree");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        /// <summary>
        /// to find the Size of data types
        /// </summary>
        public static void Question_06()
        {
            Console.WriteLine("Size of various data types in C#:");
            Console.WriteLine("int: " + sizeof(int) + "bytes");
            Console.WriteLine("float: " + sizeof(float) + "bytes");
            Console.WriteLine("double: " + sizeof(double) + "bytes");
            Console.WriteLine("char: " + sizeof(char) + "bytes");
            Console.WriteLine("bool: " + sizeof(bool) + "bytes");
            Console.WriteLine("byte: " + sizeof(byte) + "bytes");
            Console.WriteLine("short: " + sizeof(short) + "bytes");
            Console.WriteLine("long: " + sizeof(long) + "bytes");
            Console.WriteLine("decimal: " + sizeof(decimal) + "bytes");
        }
        /// <summary>
        /// to Print ASCII Value (tip: read character, print number of this char)
        /// </summary>
        public static void Question_07()
        {
            Console.Write("Enter a character: ");
            char input = Console.ReadKey().KeyChar;

            int asciiValue = Convert.ToInt32(input);
            Console.WriteLine($"The ASCII value of {input} is: {asciiValue}");
            Console.ReadKey();
        }
        /// <summary>
        /// to Calculate Area of Circle
        /// </summary>
        public static void Question_08()
        {
            Console.Write("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of the circle is {area}");
        }
        /// <summary>
        /// to Calculate Area of Square
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Enter the side: ");
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"The area of the square is {area}");
        }
        /// <summary>
        ///  to convert days to years, weeks and days
        /// </summary>
        public static void Question_10()
        {
            Console.Write("Enter the Days: ");
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int weeks = days / 7;
            int d = days % 7;
            Console.WriteLine($"{days} days is approxiately {years} years, {weeks} weeks, {d} days.");
        }
    }
}
