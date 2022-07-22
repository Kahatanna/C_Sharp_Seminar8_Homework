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