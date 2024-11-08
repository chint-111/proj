using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session_06
    {
        private static void Main (string[] args )
        {
            //Exercise01();
            //Exercise02();
            Exercise03();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        public static void Exercise01()
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

        }
    }
}
