using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    internal class session14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row=");
            int row = int.Parse(Console.ReadLine()); 
            int[][]mat=new int[row][];
            for(int i = 0;i<mat.Length;i++)
            {
                Console.WriteLine($"Enter col for row {row+1}");
                int col=int.Parse(Console.ReadLine());
                mat[i] = new int[col];
                Random ran= new Random();   
                for(int j = 0; j < mat[i].Length;j++)
                {
                    mat[i][j]=ran.Next(100);
                }
            }
            Print(mat);
            while(true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.PrintMaxMin");
                Console.WriteLine();
            }


        }
        static void Print(int[][]mat)
        {
            foreach(var row in mat)
            {
                foreach (var item in row)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
