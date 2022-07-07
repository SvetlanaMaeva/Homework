// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[10];

int size = array.Length;

Random numRandom = new Random();
int count = 0;

Console.WriteLine("Массив: ");
for (int i = 0; i < size; i++)
{
    array[i] = numRandom.Next(100, 1000);
    Console.Write($" {array[i]}");
    if ((array[i]%2) == 0)
    {
        count++;
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Чётных чисел в массиве {count} шт.");