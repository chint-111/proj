using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session6_
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            int column = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, column];

            Nhapmang2chieungaunhien(matrix);

            Console.WriteLine("\nGenerated matrix: ");
            XuatMang(matrix);

            /*Console.WriteLine("\nEnter the column index to print: ");
            int ColIndex=int.Parse(Console.ReadLine());
            Console.WriteLine($"\nColumn {ColIndex}: ");
            XuatMangColIndex(matrix, ColIndex);*/

            /*int maxValue, minValue;
            FindMaxAndMin(matrix, out maxValue, out minValue);
            Console.WriteLine($"\nThe max value of the matrix is:{maxValue}");
            Console.WriteLine($"\nThe min value of the matrix is:{minValue}");*/

            /*Console.WriteLine("\nEnter the row index:");
            int rowIndex=int.Parse(Console.ReadLine());
            int rowMinValue = FindMininRow(matrix, rowIndex);
            Console.WriteLine($"The min value in row {rowIndex} is:{ rowMinValue}");*/

            /*int[,] TransposedMatrix = transposedMatrix(matrix, row, column);
            Console.WriteLine("\nTransposed matrix:");
            XuatMang(TransposedMatrix);*/

            PrintDiagosal(matrix, row, column);

        }
        static void Nhapmang2chieungaunhien(int[,] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(100);
                }
            }
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");

                }
                Console.WriteLine();
            }
        }

        /*static void XuatMangColIndex(int[,]a,int ColIndex)
        {
            if (ColIndex < 0 || ColIndex >= a.GetLength(1))
                {
                Console.WriteLine("Unvalid column index!");
                return;
            }
            for (int i = 0;i< a.GetLength(0); i++)
            {
                Console.Write($"{a[i, ColIndex]}\t");
            }
        }*/
        /*static void FindMaxAndMin(int[,]a, out int max, out int min)
        {
            max = a[0, 0];
            min = a[0, 0];
            for(int i=0;i< a.GetLength(0); i++)
            {
                for(int j=0;j< a.GetLength(1);j++)
                {
                    if (a[i,j]> max)
                    {
                        max = a[i, j];
                    }
                    if (a[i,j]< min)
                    {
                        min = a[i, j];
                    }
                }
            }
        }*/
        /*static int FindMininRow(int[,]a,int rowIndex)
        {
            int min = a[rowIndex, 0];
            for (int j=1;j<a.GetLength(1);j++)
            {
                if (a[rowIndex, j] < min)
                {
                    min = a[rowIndex, j];
                }
            }
            return min;
        }*/
        /*static int[,] transposedMatrix(int[,] a, int row, int column)
        {
            int[,] transposed = new int[column, row];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    transposed[j, i] = a[i, j];
                }
            }
            return transposed;
        }*/
        static void PrintDiagosal (int[,] a,int row, int column)
            {
                Console.WriteLine("\nMain Diagonal: ");
                for(int i = 0;i<Math.Min(row,column);i++)
                    {
                        Console.Write($"{a[i,i]}\t");
                    }
                Console.WriteLine("\n2nd Diagonal: ");
                for (int i = 0;i<Math.Min(row,column);i++)
                    {
                        Console.Write($"{a[i,column-i-1]}\t");
                    }
            }

    }
}
