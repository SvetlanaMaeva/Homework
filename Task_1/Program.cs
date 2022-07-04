// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введи число раз: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число два, если хочешь магию: ");
int number2 = Convert.ToInt32(Console.ReadLine());


double result = Math.Pow(number1,number2);
Console.WriteLine($"Вжух! число {number1} в степени {number2} - это {result}");
