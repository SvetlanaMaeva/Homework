// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] numberArray = new double[10];
Random randomNumber = new Random();
int size = numberArray.Length;
double maxNumber = 0;
double minNumber = 0;

Console.Write("Массив: ");
for (int i = 0; i < size; i++)
{
    numberArray[i] = randomNumber.Next(-100, 100) + randomNumber.NextDouble();

    if (numberArray[i] > maxNumber) maxNumber = numberArray[i];
    if (numberArray[i] < minNumber) minNumber = numberArray[i];

}
Console.WriteLine($"[{String.Join("; ", numberArray)}]");
Console.WriteLine($" Максимальное {maxNumber}");
Console.WriteLine($" Минимальное {minNumber}");
Console.WriteLine($"Разница, между максимальным и минимальным элементов массива {maxNumber - minNumber}");