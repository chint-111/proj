using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session12
    {
        static void Main12(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n=int.Parse(Console.ReadLine());
            int[]a= new int[n];

            Random random= new Random();
            for (int i=0; i<a.Length; i++)
            {
                a[i]=random.Next(100);
            }
            Print(a);

            while(true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Average:");
                Console.WriteLine("2.Specific contain");
                Console.WriteLine("3.Index");
                Console.WriteLine("4.Remove element:");
                Console.WriteLine("5.Max and min.");
                Console.WriteLine("6.Reverse.");
                Console.WriteLine("7.Duplicate found");
                Console.WriteLine("8.Remove Duplicate:");
                Console.WriteLine("9.Exit");
                Console.WriteLine("Enter 1->9");
                
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        AverageValue(a);
                        break;
                    case 2:
                        Console.WriteLine("Enter a specific value:");
                        int spec=int.Parse(Console.ReadLine());
                        HasSpec(a, spec);

                        break;
                    case 3:
                        Console.WriteLine("Enter the element:");
                        int ele=int.Parse(Console.ReadLine());
                        int IndexFound=FindIndex(a, ele);
                        if (IndexFound != -1)
                            Console.WriteLine(IndexFound);
                        else Console.WriteLine($"{ele} is not found."); 
                        break;
                    case 4:
                        Console.WriteLine("Enter the specific:");
                        int specific=int.Parse(Console.ReadLine());
                        int[]removeSpec=RemovingSpec(a, specific);
                        Print(removeSpec);
                        break;
                    case 5:
                        FindMinMax(a);
                        break;
                    case 6:
                        Reversearray(a);
                        Print(a);
                        break;
                    case 7:
                        FoundDup(a);
                        break;
                    case 8:
                        int[] newa = RemoveDup(a);
                        Print(newa);
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Enter 1-9 plz!!!!");
                        break;
                }
            }
        }
        static void Print(int[]a)
        {
            foreach(int item in a)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();    
        }
        static void AverageValue(int[]a)
        {
            int sum = 0;
            int count = 0;
            foreach (int item in a)
            {
                sum += item;
                count++;
            }
            double ave = sum / count;
            Console.WriteLine($"Average result of array:{ave}. ");
            Console.WriteLine();
        }
        static void HasSpec(int[]a, int spec)
        {
            bool Found = false;
            foreach (int item in a)
            {
                if (item == spec)
                {

                    Console.WriteLine($"Yes. Array contain {spec}.");
                    Found = true;
                }
            }
            if (! Found) Console.WriteLine($"No. {spec} is not found.");
        }
        static int FindIndex(int[]a, int ele)
        {
            
            for(int i = 0; i < a.Length; i++)
            {
                if (ele == a[i])
                {
                    return i;
                }
            }
            return -1;
        }
        static int[] RemovingSpec( int[]a, int specific)
        {
            int count = 0;
            for (int i = 0;i < a.Length;i++)
            {
                if(specific == a[i])
                {
                    count++;
                }
            }

            if (count == 0) return a;

            int index = 0;
            int[]newarray = new int[a.Length-count];
            for (int i = 0;i<a.Length;i++)
            {
                if (a[i] != specific)
                    newarray[index++] = a[i];
            }
            return newarray;
        }
        static void FindMinMax(int[] a)
        {
            int minN = int.MaxValue;
            int maxN = int.MinValue;
            foreach(int item in a)
            {
                if (item < minN) minN = item;
                if(item > maxN) maxN = item;

            }
            Console.WriteLine($"Max: {maxN}");
            Console.WriteLine($"Min: {minN}");

        }
        static void Reversearray(int[]a)
        {
            int start = 0;
            int end = a.Length - 1;
            while(start < end)
            {
                int temp=a[start];
                a[start]=a[end];
                a[end]=temp;
                start++;
                end--;
            }
        }
        static void FoundDup(int[]a)
        {
            bool found = false;
            for(int i=0;i<a.Length-1;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i]==a[j])
                    {
                        Console.WriteLine($"Dupl: {a[i]}");
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine("No dup found.");
        }
        static int[]RemoveDup(int[]a)
        {
            List<int> list = new List<int>();
            for(int i=0;i<a.Length;i++)
            {
                bool isDup=false;
                for(int j=0;j<list.Count;j++)
                {
                    if (a[i]==list[j])
                    {
                        isDup = true;
                        break;
                    }
                }
                if(!isDup)
                {
                    list.Add(a[i]);
                }
            }
            return list.ToArray();
        }
    }
}
