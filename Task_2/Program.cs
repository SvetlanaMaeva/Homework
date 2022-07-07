//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] numberArray = new int[10];

int size = numberArray.Length;

int result = 0;

Console.Write("Массив: ");
for (int i = 0; i < size; i++)
{
    numberArray[i] = new Random().Next(1, 10);
    
    if (i % 2 != 0)
    {
        result += numberArray[i];
    }
}
Console.WriteLine($"[{String.Join("; ", numberArray)}]");

Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {result}");