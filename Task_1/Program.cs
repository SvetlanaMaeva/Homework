// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Сколько чисел ты собираешься вводить?  ");
int m = Convert.ToInt32(Console.ReadLine());
int[] fewNumbers = new int[m];
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write($"Вводи {i + 1} число: ");
    fewNumbers[i] = Convert.ToInt32(Console.ReadLine());
    if (fewNumbers[i] > 0) count += 1;
}

Console.WriteLine($"Xисел больше 0 тобой введено: {count} ");


