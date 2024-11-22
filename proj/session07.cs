using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session07
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            Exercise3();
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Exercise1()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1, 1, 1, 1, 1 };
            jaggedArray[1] = new int[] { 2, 2 };
            jaggedArray[2] = new int[] { 3, 3, 3, 3 };
            jaggedArray[3] = new int[] { 4, 4 };

            /*jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 1;
            jaggedArray[0][2] = 1;
            jaggedArray[0][3]=  1;
            jaggedArray[0][4] = 1;

            jaggedArray[1][0] = 2;
            jaggedArray[1][1] = 2;

            jaggedArray[2][0] = 3;
            jaggedArray[2][1] = 3;
            jaggedArray[2][2] = 3;
            jaggedArray[2][3] = 3;

            jaggedArray[3][0] = 4;
            jaggedArray[3][1] = 4;*/

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Exercise2()
        {
            Console.WriteLine("enter the number of rows: ");
            int row = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[row][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Enter the numbers of elements in row {i}: ");
                int col = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[col];

            }
            Random random = new Random();
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = random.Next(100);
                }
            }
            Console.WriteLine("\nJagged Array with random numbers: ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            ///Print the biggest number of each row and the largest number of the whole array.
            /*int globalMax=int.MinValue;
            for(int i=0;i < jaggedArray.Length;i++)
            {
                int MaxinRow = jaggedArray[i][0];
                for(int j=1;j< jaggedArray[i].Length;j++)
                {
                    if (jaggedArray[i][j] > MaxinRow)
                    {
                        MaxinRow=jaggedArray[i][j];
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Largest number in row{i}: {MaxinRow}");
                if(globalMax<MaxinRow)
                {
                    globalMax= MaxinRow;
                }
            }
            Console.WriteLine($"\nThe largest number of the whole array is: {globalMax}");*/


            ///Sort values ascending of each row.
            /*for(int i=0; i< jaggedArray.Length;i++)
            {
                Array.Sort(jaggedArray[i]);
                Array.Reverse(jaggedArray[i]);
            }
            Console.WriteLine("Descending values in each row of the array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j=0; j< jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]+" ");
                }
                Console.WriteLine();
            }*/

            ///Print items of the array that are prime.
            /*static bool IsPrime(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
            Console.WriteLine("Prime number in jagged array:");
            foreach (var rowArray in jaggedArray)
            {
                foreach (var item in rowArray)
                {
                    if (IsPrime(item))
                    {
                        Console.WriteLine(item + " ");
                    }
                }
            }*/

            ///Search and print all positions of a number (enter from the user).
            Console.WriteLine("Enter the number that you want to find: ");
            int number=int.Parse(Console.ReadLine());
            bool found = false;
            for(int i = 0;i < jaggedArray.Length; i++)
            {
                for(int j = 0;j < jaggedArray[i].Length;j++)
                {
                    if (jaggedArray[i][j] == number )
                    {
                        Console.WriteLine($"{number} is found in row {i} and column{j}.");
                        found = true;
                    }
                }

            }
            if (!found)
                Console.WriteLine($"{number} doesnt exist in the array. ");
        }
        static void Exercise3()
        {
            string[][][] group = new string[3][][];

            group[0] = new string[5][];
            group[0][0] = new string[] { "1", "Alice", "10" };
            group[0][1] = new string[] { "2", "Bob", "3" };
            group[0][2] = new string[] { "3", "Calic", "8" };
            group[0][3] = new string[] { "4", "Dylan", "16" };
            group[0][4] = new string[] { "5", "Emily", "9" };

            group[1] = new string[3][];
            group[1][0] = new string[] { "6", "Fed", "3" };
            group[1][1] = new string[] { "7", "Gaugre", "43" };
            group[1][2] = new string[] { "8", "Helen", "5" };

            group[2] = new string[6][];
            group[2][0] = new string[] { "9", "Ikr", "60" };
            group[2][1] = new string[] { "10", "James", "24" };
            group[2][2] = new string[] { "11", "Klairs", "31" };
            group[2][3] = new string[] { "12", "Lime", "55" };
            group[2][4] = new string[] { "13", "Monica", "11" };
            group[2][5] = new string[] { "14", "Nike", "19" };
            ///Initialize an array with pre-assigned values or values entered from the keyboard.
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine($"Group{i+1}:");
                for (int j = 0; j < group[i].Length; j++)
                {
                    string id = group[i][j][0];
                    string name= group[i][j][1];
                    string task= group[i][j][2];
                    Console.WriteLine($"ID:{id}, Name:{name}, completed tasks:{task}");                    
                }
            }
            ///Print a list of all members.
            /*Console.WriteLine("The list of all members:");
            for(int i = 0;i < group.Length;i++)
            {
                for (int j = 0;j < group[i].Length;j++)
                {
                    string No= group[i][j][0];
                    string member= group[i][j][1];
                    Console.WriteLine($"{No}:{member}");
                }
            }
            ///Print the information on a member when the ID is known.
            Console.WriteLine("enter the ID:");
            string ID=Console.ReadLine();
            bool found = false;
            for (int i = 0;i<group.Length;i++)
            {
                for(int j = 0;j<group[i].Length;j++)
                {
                    if (ID == group[i][j][0])
                    {
                        Console.WriteLine($"{ID} is belongs to {group[i][j][1]}");
                        found = true;
                        break;
                    }
                }
            }
            if(!found)
            {
                Console.WriteLine("ID is not found.");
            }*/

            ///Print the member with the highest number of completed tasks.
            
            int MaxTask=int.MinValue;
            string memID = "";
            string memName = "";
            for (int i = 0; i < group.Length; i++)
            {
                 for (int j = 0; j < group[i].Length; j++)
                {
                    int task = int.Parse(group[i][j][2]);
                    if(task>MaxTask)
                    {
                        MaxTask = task;
                        memID = group[i][j][0];
                        memName=group[i][j][1];
                    }
                }
            }
            Console.WriteLine($"Member with highest completed tasks:ID:{memID},Name: {memName}");



        }
    }
}
