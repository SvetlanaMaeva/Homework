// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введи количество строчек: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какое число будем проверять? ");
int verificationNumber = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

void CheckForavAilability(int[,] array)
{
    bool existsElement = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (matrix[i, j] == verificationNumber)
            {
                Console.WriteLine($"Позиция введённого элемента {verificationNumber} -> matrix[{i},{j}]");
                existsElement = true;
            }
        }
    }
    if (existsElement == false) Console.WriteLine("Такого элемента нет :(");
}
CheckForavAilability(matrix);