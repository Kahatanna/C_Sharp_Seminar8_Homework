/*

Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)

*/

using System;
using System.Collections;
using System.Linq;

Dictionary<int, int> dict = new Dictionary<int, int>();

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))

            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int[,,] FillArrayDistinct(int m, int n, int p)
{
    int[,,] matrix = new int[m, n, p];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                matrix[i, j, k] = FindUnicNumber();
            }
        }
    }
    return matrix;
}

int FindUnicNumber()
{
    int result = new Random().Next(1, 100);

    if (dict.Keys.Contains(result)) FindUnicNumber();
    else dict.Add(result, 1);

    return result;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {                  
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int m = GetNumber("Введите первую размерность массива m: ");
int n = GetNumber("Введите вторую размерность массива n: ");
int p = GetNumber("Введите третью размерность массива p: ");



int[,,] matrix = FillArrayDistinct(m, n, p);
PrintMatrix(matrix);
