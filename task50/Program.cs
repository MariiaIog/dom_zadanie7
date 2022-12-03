/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int[,] GetRandomArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}
void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void OutputUserElement(int[,] array)
{
    Console.Write("Введите позицию элемента: ");
    int userElement = Convert.ToInt32(Console.ReadLine());
    int a = userElement % array.GetLength(1);
    int b = userElement / array.GetLength(1);

    if (a < array.GetLength(1) & b < array.GetLength(0))
    {
        int x = array[b, a];
        Console.Write($"i={a}, j={b}. Значение элемента равно {x}");
    }
    else
    {
        Console.Write("Такого элемента не существует");
    }
    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
int[,] array1 = GetRandomArray(3, 4, 10);
print2dArray(array1);
Console.WriteLine();
OutputUserElement(array1);
Console.ResetColor();