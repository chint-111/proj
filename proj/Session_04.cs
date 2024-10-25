using System.ComponentModel.Design;
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
			Exercise6();
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
			for (int y = -5; y< 5; y++)
			{
				int x=y*y + 2*y + 1;
                Console.WriteLine($"y ={y}, x={x}");
            }

        }
        public static void Exercise3()
		{
			Console.WriteLine("enter the distance in kilometers= ");
			double dis1=double.Parse(Console.ReadLine());
			double dis2 = dis1 * 0.6214;
			Console.WriteLine("enter the time (hours)= ");
			int h=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the time (minutes)");
			int min= int.Parse(Console.ReadLine());
			Console.WriteLine("enter the time (second)");
			int sec=int.Parse(Console.ReadLine());
			int hour = h + (min / 60) + (sec / 3600);
			double v1 = dis1 / hour;
			Console.WriteLine($"Speed in km/h = {v1}");
            double v2 = dis2 / hour;
            Console.WriteLine($"Speed in km/h = {v2}");
        }
        public static void Exercise4()
		{
            Console.WriteLine("enter the radius= ");
			double r=double.Parse(Console.ReadLine());
			double surface = 4 * Math.PI * Math.Pow(r, 2);
			Console.WriteLine($"surface of a sphere = {surface}");
			double vol=(4/3)*Math.PI* Math.Pow(r,3);
			Console.WriteLine($"volume of a sphere={vol}");
        }
        public static void Exercise5()
		{
            Console.WriteLine("enter a character"	);
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



}

