/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.*/

int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    {
        for (int i = 0; i < lengthRow; i++)
        {
            for (int j = 0; j < lengthCol; j++)
            {
                array[i, j] = new Random().Next(deviation);
            }
        }
    }

    return array;
}

void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void AverageArray(int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = summ + array[i, j];
        }
        average = summ / array.GetLength(0);
        average = Math.Round(average, 1);
        Console.WriteLine($"Среднее арифметическое {j} столбца: {average}");
    }
}

int[,] array = generate2DArray(3, 4, 10);
print2dArray(array);
Console.WriteLine();
AverageArray(array);