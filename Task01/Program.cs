/*

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8

*/


using System;
using System.Collections;

int[][] InitMatrix(int m, int n)
{
    int[][] matrix = new int[m][];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        matrix[i] = new int[n];
        for (int j = 0; j < matrix[i].Length; j++)
        {
            matrix[i][j] = randomizer.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[][] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            Console.Write($"{matrix[i][j]}  ");
        }
        Console.WriteLine();
    }
}

int[][] ChangeMatrix(int[][] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        Array.Sort(matrix[i]);
    }
    return matrix;
}

// int[] SortArray(int[] arr)
// {
//     int min = arr[0];
//     int count = arr.Length;
//     int[] result = new int[count];

//     if (count < 2) return arr;
//     else
//     {
//         int pivot = arr[0];
//         int[] less;
//         int[] greater;

//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] >= pivot)
//             { 
//                 Array.Resize<int>(greater, greater.Length+1);
//                 greater[greater.Length-1] = arr[i];
//             } 
//             else
//             {
//                 Array.Resize<int>(less, less.Length+1);
//                 less[less.Length-1] = arr[i];
//             }
//         }



//         result = Unify(SortArray(less), pivot,  SortArray(greater));
//         return result;
//     }
// }

// int[] Unify (int[] a, int p, int[] b)
// {
//    int[] c = new int[a.Length+b.Length + 1];
//    for(int i = 0; i < a.Length; i++)
//       c[i] = a[i];
//     c[a.Length+1] = p;
//    for(int j = 0; j < b.Length; j++)
//       c[a.Length + j + 1] = b[j];
//    return c;
// }


Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

int[][] matrix = InitMatrix(m, n);

Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();

PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(ChangeMatrix(matrix));