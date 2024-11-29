using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row=");
            int row=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter col=");
            int col=int.Parse(Console.ReadLine());
            int[,]a= new int[row, col];
            Random random=new Random();
            for(int i = 0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = random.Next(100);
                }
            }
            Print(a);
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Print n row/col.(i was entered from use).");
                Console.WriteLine("2.Find min,max of row/col and matrix");
                Console.WriteLine("3.PRint main/sec diagonal values");
                Console.WriteLine("4.Exit");
                Console.WriteLine("enter qquestion:");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Print(a);
                        break;
                    case 2:
                        FindMinMAx(a);
                        break;
                    case 3:
                        PrintDia(a, row, col);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Enter 1->4 plz");
                        break;
                }
            }

        }
        static void Print(int[,] a)
        {
            for(int i=0;i<a.GetLength(0); i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void FindMinMAx(int[,] a)
        {
            int globalmin = int.MaxValue;
            int globalmax=int.MinValue; 
            for(int i=0;i<a.GetLength(0);i++)
            {
                int rowmin = int.MaxValue;
                int rowmax= int.MinValue;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (a[i,j] < rowmin) rowmin = a[i,j];
                    if(a[i,j] > rowmax) rowmax = a[i,j];

                    if(rowmin < globalmin) globalmin = rowmin;
                    if(rowmax > globalmax) globalmax = rowmax;
                }
                Console.WriteLine($"MAx of row{i+1}: {rowmax}");
                Console.WriteLine($"Min of row{i+1}:{rowmin}");
            }
            Console.WriteLine($"Max of array: {globalmax}");
            Console.WriteLine($"Min of array: {globalmin}");
        }
        static void PrintDia(int[,]a,int row, int col)
        {
            Console.WriteLine("\n Main Diagonal:");
            for (int i = 0; i < Math.Min(row, col); i++)
                Console.Write($"{a[i,i]}\t ");
            Console.WriteLine("\n2ndDiagonal:");
            for(int i = 0;i < Math.Min(row, col);i++)
                Console.Write($"{a[i,col-i-1]}\t");
        }
    }
}
