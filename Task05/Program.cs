/*

Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7

*/

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

int[,] FillMatrixBySnake(int m, int number0)
{
    int[,] result = new int[m, m];

    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for (int i = 0; i < result.Length; i++)
    {
        result[col, row] = number0++;
        if (--gran == 0)
        {
            gran = m*(dirChanges%2) + m*((dirChanges + 1)%2) - (dirChanges/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return result;
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



int m = GetNumber("Введите размер матрицы: ");
int startNumber = GetNumber("Введите начальное число: ");
int[,] matrix = FillMatrixBySnake(m, startNumber);
Console.WriteLine();
PrintMatrix(matrix);
