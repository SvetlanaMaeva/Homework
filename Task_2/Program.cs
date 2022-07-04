// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введи число. Но только число, иначе всё сломается!");
int number1 = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number1 > 0)
{
    sum = sum + number1 % 10;
    number1 = number1 / 10;
}

Console.WriteLine(sum);