using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session_06
    {
        private static void Main6(string[] args)
        {
            //Exercise01();
            //Exercise02();
            //Exercise03();
            //Exercise04();
            //Exercise05();
            //Exercise06();
            //Exercise07();
            //Exercise08();
            //Exercise09();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        /*public static void Exercise01()
         { 
             int n =int.Parse(Console.ReadLine());
             Console.WriteLine(n);
             int[] a = new int[n];
             SinhMangNgauNhien(a);
             InMang(a);
             Sum(a);
             increaseItems(a, 2);
             InMang(a);
             Sum(a);
         }
         static void SinhMangNgauNhien(int[] a)
         {
             Random random=new Random();
             for (int i = 0; i< a.Length; i++)
             {

                 a[i]=random.Next(100); 
             }
         }
         static void InMang(int[]a)
         {
             foreach(int item in a)
             {
                 Console.Write($"{item}, ");
             }
             Console.WriteLine();
         }
         static void increaseItems(int[] a, int val)
         {
             for (int i = 0; i < a.Length; i++)
             {
                 a[i] += val;
             }
         }
         static void Sum(int[] a)
         {
             int s = 0;
             foreach (int item in a)
             { s += a[item]; }
             Console.WriteLine($"Sum: {s}");
         }
         public static void Exercise02()
         {
             int n=int.Parse(Console.ReadLine());
             Console.WriteLine(n);
             int[] a=new int[n];
             BienNgauNhien(a);
             In(a);
             Average(a);

         }
         static void BienNgauNhien(int[]a)
         {
             Random ran=new Random();
             for(int i = 0;i< a.Length;i++)
             {
                 a[i] = ran.Next(100);
             }
         }
         static void In(int[] a)
         {
             Console.WriteLine("Random vars: ");
             foreach (int item in a)
             {
                 Console.Write($"{item}, ");
             }
             Console.WriteLine();
         }
         public static void Average(int [] a)
         {
             int sum = 0; 
             int count = a.Length;
             foreach(int item in a)  
             {
                 sum += item;
             }
             double average = sum / count;
             Console.WriteLine($"The average : {average:F2}");
         }
         public static void Exercise03()
         {
             Console.Write( "Enter a number: ");
             int n=int.Parse(Console.ReadLine());
             int[] a = new int[n];

             BienNgauNhien(a);
             InMang(a);

             Console.WriteLine();
             Console.Write("Enter the specific number: ");
             int specific=int.Parse(Console.ReadLine());

             bool SpecificValueFound = HasSpecificValue(a, specific);
             if (SpecificValueFound)
             {
                 Console.WriteLine($"The array contains the value {specific}");
             }
             else
             {
                 Console.WriteLine($"The array doesnt contain the value {specific}. "); 
             }
         }
         public static void BienNgauNhien(int[] a)
         {
             Random random = new Random();
             for (int i = 0;i<a.Length;i++)
             {
                 a[i]=random.Next(100);
             }
         }
         public static void InMang(int[] a)
         {
             foreach (int item in a)
             { 
                 Console.Write($"{item}, "); 
             }
             Console.WriteLine();
         }
         public static bool HasSpecificValue(int[] a, int specific)
         {
             foreach(int item in a)
             {
                 if(item==specific)
                 {
                     return true;
                 }
             }
             return false;
         }
        public static void Exercise04()
         {
             Console.WriteLine("Enter the number of array: ");
             int n=int.Parse( Console.ReadLine() );
             int[] a = new int[n];
             BienNN(a);
             Print(a);

             Console.Write("Enter an array element: ");
             int ele=int.Parse( Console.ReadLine() );

             int indexFound = FoundInElement(a, ele);
             if(indexFound != -1 )
             {
                 Console.WriteLine($"The array element's index is {indexFound}");
             }
             else
             {
                 Console.WriteLine($"The array element doesnt exist.");
             }
         }
         static void BienNN(int[]a)
         {
             Random random=new Random();
             for(int i=0; i<a.Length; i++)
             {
                 a[i] = random.Next(1000);
             }
         }
         static  void Print(int[]a)
         {
             Console.WriteLine("Numbers: ");
             foreach(int item in a)
             {
                 Console.Write($"{item}, ");
             }
             Console.WriteLine();
         }
         static int FoundInElement(int[]a,int ele)
         {
             for(int i=0 ; i<a.Length ; i++)
             {
                 if (a[i]==ele)
                 {
                     return i;
                 }
             }
             return -1;
         }
        public static void Exercise05()
        {
            Console.WriteLine("Enter the number of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            BNN(a);
            IM(a);

            Console.WriteLine("Enter the specific element: ");
            int element = int.Parse(Console.ReadLine());

            int[] newArray = RemoveElement(a, element);

            Console.WriteLine("The new array after removing element: ");
            foreach(int item in newArray)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        static void BNN(int[] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1000);
            }
        }
        static void IM(int[] a)
        {
            Console.Write("Value: ");
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static int[] RemoveElement(int[] a, int element)
        {
            int count = 0;

            foreach (int item in a)
            {
                if (item == element)
                {
                    count++;
                }
            }

            if (count == 0) return a;

            int[] newArray = new int[a.Length - count];
            int index = 0;

            foreach (int item in a)
            {
                if (item != element)
                {
                    newArray[index++] = item;
                }

            }
            return newArray;
        }
        public static void Exercise06()
        {
            Console.WriteLine("Enter the number of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            BNN(a);
            IM(a);
            FindMaxMin(a);
        }
        static void BNN(int[] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1000);
            }
        }
        static void IM(int[] a)
        {
            Console.Write("Value: ");
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void FindMaxMin(int[]a)
        {
            int max = a[0];
            int min = a[0];
            foreach(int item in a)
            {
                if(item > max)
                {
                    max = item;
                }
                if(item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimun value: {min}");
        }*/
        /*public static void Exercise07()
        {
            Console.Write("Enter the number of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Bnn(a);
            In(a);
            Reverse(a);
            Console.WriteLine("Reversed array: ");
            In(a);
        }
        static void Bnn(int[] a)
        {
            Random random = new Random();
            for (int i=0;i<a.Length; i++)
            {
                a[i] = random.Next(100);

            }
        }
        static void In(int[] a)
        {
            Console.WriteLine("Values of array: ");
            foreach (int item in a)
            {
                Console.Write(item + " ");              
            }
            Console.WriteLine();
        }
        static void Reverse(int[] a)
        {
            int left = 0;
            int right=a.Length-1;
            while(left<right)
            {
                int temp = a[left];
                a[left] = a[right];
                a[right] = temp;

                left++;
                right--;
            }
        }
        public static void Exercise08()
        {
            Console.Write("Enter the number of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Bnn(a);
            In(a);

            FindDuplicates(a);
 
        }
        static void Bnn(int[] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);

            }
        }
        static void In(int[] a)
        {
            Console.WriteLine("Values of array: ");
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void FindDuplicates(int[]a)
        {
            bool found= false;
            for (int i = 0;i < a.Length-1;i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.WriteLine("Duplicate found is: " + a[i]);
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No duplicates found yet");
            }
        }*/
        public static void Exercise09()
        {
            Console.Write("Enter the number of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Bien(a);
            Inmang(a);

            int[]uniqueArray=RemoveDup(a);
            Console.WriteLine("Array after removing duplicates: ");
            Inmang(uniqueArray);
        }
             
        static void Bien(int[] a)
            {
                Random random = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(100);

                }
            }
        static void Inmang(int[] a)
            {
                foreach (int item in a)
                    {
                        Console.Write(item + " ");
                    }
                Console.WriteLine();
            }
        static int[] RemoveDup(int[] a)
        {
            int[] temp = new int[a.Length];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool isDuplicate = false;
                for(int j = 0;j<i;j++)
                {
                    if (a[i]== a[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if(!isDuplicate)
                {
                    temp[index] = a[i];
                    index++;
                }
            }
            int[] result = new int[index];
            Array.Copy(temp, result, index);
            return result;
            
        }
       
        
    }
}
