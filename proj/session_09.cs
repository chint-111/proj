using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session_09
    {
        static void Main9(string[]args)
        {
            // Exercise01();
            //Exercise02();
            //Exercise03();
            //Exercise04();
            //Exercise05();
            //Exercise06();
            //Exercise07();
            //Exercise08();
            //Exercise09();
            Exercise10();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        static void Exercise01()
        {
            Console.Write("Enter X= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter Y=");
            double y= double.Parse(Console.ReadLine()); 

            if(x>0&&y>0)           
                Console.WriteLine($"The coordinate point " +
                    $"({x},{y}) lies in the first quadrant");
            
            else if (x<0&&y>0)
                Console.WriteLine($"The coordinate point " +
                    $"({x} , {y}) lies in the second quadrant");
            else if (x<0&&y<0)
                Console.WriteLine($"The coordinate point " +
                    $"({x} , {y}) lies in the third quadrant");
            else if (x>0&&y<0)
                Console.WriteLine($"The coordinate point " +
                    $"({x}  ,  {y}) lies in the forth quadrant");
            else if(x==0&&y!=0)
                Console.WriteLine($"The coordinate point " +
                    $"({x}  ,  {y}) lies at the Y-axix");
            else if(x!=0&&y==0)
                Console.WriteLine($"The coordinate point " +
                    $"({x}  ,  {y}) lies at the X-axix");
            else Console.WriteLine($"The coordinate point " +
                    $"({x}   ,   {y}) lies at the origin.");
        }
        static void Exercise02()
        {
            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void Exercise03()
        {
            int a = 1;
            int b = 7;
            for (int i=1;i<=4;i++)
            {
                int space = (b - i) / 2;
                Console.Write(new string(' ', space));
                for(int j=1;j<=i;j++)
                {
                    Console.Write(a+" ");
                    a++;
                }
                Console.WriteLine();
            }
        }
        static void Exercise04()
        {
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());    
            int c=int.Parse(Console.ReadLine());
            Console.WriteLine($"The largest is {FindMax(a,b,c)}.");

        }
        static int FindMax(int a, int b,int c)
        {
            return Math.Max(a,Math.Max(b,c));
        }
         static void Exercise05()
        {
            int a = int.Parse(Console.ReadLine());
            if(a==0)
                Console.WriteLine($"Factorial of {a} is 1.");
            else if(a>0)
            {
                Console.WriteLine($"Factorial of {a} is {result(a)}");
            }
            else Console.WriteLine("Enter a non-negative integer.");
        }
        static int result(int a)
        {
            int f = 1;
            for(int i=1;i<=a;i++)
            {
                f *= i;
                
            }
            return f;
        }
        static void Exercise06()
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 2) Console.WriteLine($"{a} is not prime.");
            else if (a == 2 || a == 3) Console.WriteLine($"{a} is prime.");
            else 
            {
                if (IsPrime(a)) Console.WriteLine($"{a} is prime.");
                else Console.WriteLine($"{a} is not prime.");
            }
        }
        static bool IsPrime(int a)
        {
            for(int i=2; i*i<=a ; i++)
            {
                if (a % i == 0) return false;            
            }
            return true;
        }
        static void Exercise07()
        {
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime numbers less than {n}");

            for(int i=2;i<n;i++)
            {
                if (IsItPrime(i))
                { 
                    Console.Write(i + " "); 
                }
            }
            Console.WriteLine();
            PrintFirstPrime(n);
        }
        static bool IsItPrime(int num)
        {
            if (num < 2) return false;
        
            for (int j = 2; j * j <= num; j++)
                {
                    if (num % j == 0) return false;
                }
            return true;
                                    
        }
        static void PrintFirstPrime(int n)
        {
            int count = 0;
            int num = 2;
            Console.WriteLine($"The first {n} prime numbers:");
            while(count<n)
            {
                if(IsPrime(num))
                {
                    Console.Write(num+ " ");
                    count++;
                }
                num++;
            }
            Console.WriteLine();
        }
         static void Exercise08()
        {
            int a=int.Parse(Console.ReadLine());
            if (IsPer(a))
                Console.WriteLine($"{a} is perfect.");
            else Console.WriteLine($"{a} is not perfect.");
        }
        static bool IsPer(int a)
        {
            int sum = 0;
            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == a) return true;
            return false;
        }
        static void Exercise09()
        {
            Console.WriteLine("Enter n:");
            int n=int.Parse(Console.ReadLine());

            int[]a= new int[n];
            SinhMang(a);
            In(a);


            Console.WriteLine("Enter an element:");
            int element=int.Parse(Console.ReadLine());
            int[] newarray = RemoveElement(a, element);
            Console.WriteLine("The array after removing element:");
            if (newarray.Length == a.Length)
            {
                Console.WriteLine("Element is not found. no changes made.");
            }
            else In(newarray);

            //DuplicateFound(a);

            int[] newa = RemoveDup(a);
            Console.WriteLine("Array after remove duplicates:");
            In(newa);
        }
        static void SinhMang(int[]a)
        {
            Random random=new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
            }
        }
        static void In(int[]a)
        {
            Console.WriteLine("Print the array:");
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static int []RemoveElement(int[]a, int element)
        {
            int count = 0;
            foreach (int item in a)
            {
                if(item==element) count++;
            }
            if (count == 0) return a;

            int[] newarray = new int[a.Length - count];
            int index = 0;

            foreach(int item in a)
            {
                if(element != item)
                {
                    newarray[index++] = item;
                }
            }
            return newarray;    
        }
        static void DuplicateFound(int[]a)
        {
            bool found = false;
            for (int i = 0;i < a.Length-1;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i]== a[j])
                    {
                        Console.WriteLine($"Duplicate found: {a[i]}.");
                        found = true;
                        break;
                    }    
                }
            }
            if (!found) Console.WriteLine("No duplicates found.");
        }

        static int[]RemoveDup(int[]a)
        {
            int count = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        a[j] = int.MinValue;
                        count++;
                    }
                }
            }


            if (count == 0)
                {
                    Console.WriteLine("No Duplicate found.No change made to array.");
                    return a;
                }

                int index = 0;
                int[]newa= new int[a.Length-count];
                foreach(int item in a)
                {
                    if(item!=int.MinValue)
                    {
                        newa[index++] = item;
                    }
                }
                return newa;

            
        }
        static void Exercise10()
        {
            Console.WriteLine("Enter the row:");
            int row=int.Parse(Console.ReadLine());
            int[][]jagged=new int[row][];

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine($"Enter the column for row{i}:");
                int col = int.Parse(Console.ReadLine());
                jagged[i] = new int[col];

                Random random = new Random();
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = random.Next(100);
                }
            }

            Printarray(jagged);
            
            while(true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Print the biggest number of each row and the largest number of the whole array.");
                Console.WriteLine("2.Sort values ascending of each row");
                Console.WriteLine("3.Print items of the array that are prime");
                Console.WriteLine("4.Search and print all positions of a number (enter from the user).");
                Console.WriteLine("5.Exit.");
                Console.WriteLine("Enter the function (1->4):");
                int choice=int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        PrintMax(jagged);
                        break;
                    case 2:
                        SortRow(jagged);
                        break;
                    case 3:
                        PrintPrime(jagged);
                        break;
                    case 4:
                        Console.WriteLine("Enter X:");
                        int x=int.Parse(Console.ReadLine());
                        LocationFound(jagged,x);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("PLZ enter 1-4.");
                        break;
                }
            }
        }
        static void Printarray(int[][]jagged)
        {
            foreach (var row in jagged)
            {
                foreach (var item in row)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintMax(int[][]jagged)
        {
            int globalMax = int.MinValue;
            for(int i=0; i<jagged.Length; i++)
            {
                int RowMax = int.MinValue;
                for(int j=0; j<jagged[i].Length; j++)
                {
                    if(jagged[i][j]>RowMax) RowMax=jagged[i][j];
                    if (jagged[i][j]>globalMax) globalMax = jagged[i][j];
                }
                Console.WriteLine($"Biggest number of  row{i}: {RowMax}.");
            }
            Console.WriteLine($"Biggest number of the whole array:{globalMax}.");
        }
        static void SortRow(int[][]jagged)
        {
            foreach(var row in jagged)
            {

                    Array.Sort(row);
                
            }
            Printarray(jagged);
        }
        static void PrintPrime(int[][]jagged)
        {
            Console.WriteLine("PRime numbers in array:");
            foreach(var row in jagged)
            {
                foreach(var item in row)
                {
                    if(IsPrimeNum(item))
                    {
                        Console.WriteLine(item+" ");
                    }
                }
            }
            Console.WriteLine();
        }
        static bool IsPrimeNum(int num)
        {
            if(num<2) return false;
            for(int i=2; i*i<=num;i++)
            {
                if(num%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        static void LocationFound(int[][]jagged,int x)
        {
            bool found = false;
            for(int i=0; i<jagged.Length; i++) 
            {
                for(int j = 0; j < jagged[i].Length;j++)
                {
                    if (jagged[i][j] ==x)
                    {
                        Console.WriteLine($"{x} is at [{i},{j}].");
                        found = true;
                    }
                }
            }
            if(!found) Console.WriteLine("No X found in array.");
        }
    }
}
 