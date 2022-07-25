// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введи начальное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumber(start+1, end));
}
Console.WriteLine(PrintNumber(M, N));