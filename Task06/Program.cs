/*

Задачка на дом со *
Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

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

float factorial(int n)
    {
        float i, x = 1;
        for (i = 1; i <= n; i++)
        {
            x *= i;
        }
        return x;
    }

void DrowTreanglePascal(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++) 
        {
            Console.Write("  "); 
        }
        for (int c = 0; c <= i; c++)
        {
            Console.Write("  "); 
            Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); 
        }
        Console.WriteLine();
        Console.WriteLine(); 
    }
    Console.ReadLine();
}


int n = GetNumber("Введите количество строк для отображения: ");
DrowTreanglePascal(n); 
