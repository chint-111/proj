using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;

namespace proj
{
	internal class session_04
	{
		public static void Main(string[] args)
		{
			//Exercise1();
			//Exercise2();
			//Exercise3();
			//Exercise4();
			//Exercise5();
			//Exercise6();
			//Exercise7();
			//Exercise8();
			//Exercise9();
			//Exercise10();
			//Exercise11();
			//Exercise12();
			//Exercise13();
			//Exercise14();
			Exercise15();
			Console.WriteLine("Press any key to stop");
			Console.ReadKey();
		}
		public static void Exercise1()
		{
			Console.Write("first num a= ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("second num b= ");
			double b = double.Parse(Console.ReadLine());
			double sum = a + b;
			Console.WriteLine($"{a}+{b}={sum}");
			double sub = a - b;
			Console.WriteLine($"{a}-{b}={sub}");
			double times = a * b;
			Console.WriteLine($"{a}*{b}={times}");

			if (b != 0)
			{
				double div = a / b;
				Console.WriteLine($"{a} / {b}= {div}");
			}
			else Console.WriteLine($"divided by zero exception");
		}
		public static void Exercise2()
		{
			for (int y = -5; y < 5; y++)
			{
				int x = y * y + 2 * y + 1;
				Console.WriteLine($"y ={y}, x={x}");
			}

		}
		public static void Exercise3()
		{
			Console.WriteLine("enter the distance in kilometers= ");
			double dis1 = double.Parse(Console.ReadLine());
			double dis2 = dis1 * 0.6214;
			Console.WriteLine("enter the time (hours)= ");
			int h = int.Parse(Console.ReadLine());
			Console.WriteLine("enter the time (minutes)");
			int min = int.Parse(Console.ReadLine());
			Console.WriteLine("enter the time (second)");
			int sec = int.Parse(Console.ReadLine());
			int hour = h + (min / 60) + (sec / 3600);
			double v1 = dis1 / hour;
			Console.WriteLine($"Speed in km/h = {v1}");
			double v2 = dis2 / hour;
			Console.WriteLine($"Speed in km/h = {v2}");
		}
		public static void Exercise4()
		{
			Console.WriteLine("enter the radius= ");
			double r = double.Parse(Console.ReadLine());
			double surface = 4 * Math.PI * Math.Pow(r, 2);
			Console.WriteLine($"surface of a sphere = {surface}");
			double vol = (4 / 3) * Math.PI * Math.Pow(r, 3);
			Console.WriteLine($"volume of a sphere={vol}");
		}
		public static void Exercise5()
		{
			Console.WriteLine("enter a character");
			char input = Console.ReadKey().KeyChar;
			if (char.IsLetter(input))
			{
				switch (char.ToUpper(input))
				{
					case 'A':
					case 'E':
					case 'I':
					case 'O':
					case 'U':
						Console.WriteLine($"{input} is a vowel.");
						break;
					default:
						Console.WriteLine($"{input} is a consonant.");
						break;
				}
			}
			else if (char.IsDigit(input))
			{
				Console.WriteLine($"{input} is a digit.");

			}
			else
			{
				Console.WriteLine($"{input} is a symbol.");
			}


		}
		public static void Exercise6()
		{
			Console.WriteLine("enter a number=");
			double n = double.Parse(Console.ReadLine());
			if (n / 2 == 0)
			{
				Console.WriteLine($"{n} is even");
			}
			else Console.WriteLine($"{n} is odd.");

		}
		public static void Exercise7()
		{
			Console.WriteLine("Enter 3 numbers :");
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double c = double.Parse(Console.ReadLine());
			double largest = Math.Max(a, Math.Max(b, c));
			Console.WriteLine($"The largest number is {largest}");

		}
		public static void Exercise8()
		{
			Console.WriteLine("enter the X coordinate: ");
			double x = double.Parse(Console.ReadLine());
			Console.WriteLine("enter the Y coordinate:");
			double y = double.Parse(Console.ReadLine());
			var point = (x, y);
			string location;
			switch (point)
			{
				case ( > 0, > 0):
					location = "The coodianate point ({x},{y}) lies in the First quandrant";
					break;
				case ( < 0, > 0):
					location = "The coodianate point ({x},{y}) lies in the Second quandrant";
					break;
				case ( < 0, < 0):
					location = "The coodianate point ({x},{y}) lies in the Third quandrant";
					break;
				case ( > 0, < 0):
					location = "The coodianate point ({x},{y}) lies in the Fourth quandrant";
					break;
				case (0, 0):
					location = "The coodianate point ({x},{y}) lies at the origin";
					break;
				case (0, _):
					location = "The coodianate point ({x},{y}) lies on the X-axis ";
					break;
				case (_, 0):
					location = "The coodianate point ({x},{y}) lies on the Y-axis";
					break;
				default:
					location = "unvalid";
					break;
			}
			Console.WriteLine(location);
		}
		public static void Exercise9()
		{
			Console.WriteLine("Enter 3 sides of a triangle: ");
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double c = double.Parse(Console.ReadLine());
			string result;
			if (a <= 0 || b <= 0 || c <= 0)
			{
				result = "Unvalid";
			}
            else if (a==b && b==c)
            {
				result = "this is Equilateral triangle. ";
            }
			else if (a==b||b==c||a==c)
			{
				result = "this is an Isosceles triangle.";
			}
            else
            {
				result = "this is a Scalene triangle.";
            }
			Console.WriteLine(result);
        }
        public static void Exercise10()
		{
			int count = 10;
			double sum = 0;
			for (int i=1; i<=count; i++)
			{
				Console.Write($"enter number {i}:");
				double num=double.Parse(Console.ReadLine());
				sum += num;
			}
			double ave=sum/count;
			Console.WriteLine($"Sum = {sum}");
			Console.WriteLine($"Average = {ave}");
		}
        public static void Exercise11()
		{
			Console.Write("enter an integer: ");
			int a=int.Parse(Console.ReadLine());
			for (int i=1;i<=10;i++)
			{
				int result = a * i;
				Console.WriteLine($"{a}*{i}={result}");
			}
		}
        public static void Exercise12()
		{
			Console.Write("enter the number: ");
			int a= int.Parse(Console.ReadLine());
			if (a>0)
			{
				for(int i=1;i<=a;i++)
				{
					for(int j = 1; j <= i; j++) 
					{
						Console.Write(j + "");
					}
					Console.WriteLine();
				}
			}
			else 
			{
				Console.WriteLine("unvalid");
			}
		}
		public static void Exercise13()
		{
			Console.Write("enter n= ");
			int n = int.Parse(Console.ReadLine());
			double sum = 0;
			if (n > 0)
			{
				for (int i = 1; i <= n; i++)
				{
					
					Console.Write($"1/{i} ");
					sum += 1 / i;				 
				}
				Console.WriteLine();
				Console.WriteLine($"The sum of {n} numbers is {sum} ");
			}
			else 
			{ 
				Console.WriteLine("unvalid"); 
			}
		}
        public static void Exercise14()
		{
			Console.Write("enter a number: ");
			int n= int.Parse(Console.ReadLine());
			double sum = 0;
			if (n>0)
			{
				for (int i = 1; i <= n / 2; i++)
				{
					if (n % i == 0)
					{
						sum += i;
					}
					
				}
				if (sum==n)
				{
					Console.WriteLine($"{n} is a perfect number");
				}
				else
				{
					Console.WriteLine($"{n} is not a perfect number");
				}
			}
			else
			{
				Console.WriteLine("unvalid");
			}
		}
        public static void Exercise15()
		{

		}
    }

}

