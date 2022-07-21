/*

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49

*/

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] IntegMatrix(int[,] matrix1, int[,] matrix2, int m)
{
    int[,] newMatrix = new int[m, m];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < m; k++)
            {
                newMatrix[i,j] += matrix1[i,k]*matrix2[k,j];
            }
        }
    }
    return newMatrix;
}


Console.WriteLine("Введите размер матриц: ");
int m = int.Parse(Console.ReadLine());
//int n = int.Parse(Console.ReadLine());

int[,] matrix1 = InitMatrix(m, m);
int[,] matrix2 = InitMatrix(m, m);

Console.WriteLine($"Матрица 1 размером {m}x{m}:");
PrintMatrix(matrix1);

Console.WriteLine($"Матрица 2 размером {m}x{m}:");
PrintMatrix(matrix2);

int[,] newMatrix = IntegMatrix(matrix1, matrix2, m);
Console.WriteLine($"Результат умножения:");
PrintMatrix(newMatrix);