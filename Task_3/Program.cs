// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Random numRandom = new Random();

Console.Write("Вот ваш массив, полюбуйтесь: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = numRandom.Next(0, 1000);
    Console.Write($" {array[i]}");
}
