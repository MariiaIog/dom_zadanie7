/* Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.*/

double[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    double[,] array = new double[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}

void print2DArray(double[,] array)
{
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

double[,] array = generate2DArray(4, 6, 50);

print2DArray(array);

Console.WriteLine();