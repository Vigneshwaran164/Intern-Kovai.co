// See https://aka.ms/new-console-template for more information
using System;

namespace MultiDimensionalArray 
{
    class MultiDimensionalArray
    {
        static void Main(string[] args)
        {
            //Program for transpose of a matrix
            Console.WriteLine("Transpose of Matrix");
            Console.WriteLine("--------------------");
            Console.WriteLine("Input the size of the square matrix:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size,size];
            int[,] transpose = new int[size,size];

            Console.WriteLine("Input elements in the matrix:");

            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {     
                    Console.Write($"element - [{i},{j}] :");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());

                }

            }
            Console.WriteLine("Input elements in the second matrix:");

            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {     
                    transpose[i,j] = matrix[j,i];
                }

            }
            Console.WriteLine("The Transpose of matrix is ");

            int[,] matrix3 = new int[size,size];
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {     
                   

                    Console.Write($"{transpose[i,j]} ");
          
                }
                Console.WriteLine();

            }   

        }
    }
}
