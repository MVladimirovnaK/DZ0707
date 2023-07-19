// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Random num = new Random ();
int number = num.Next(100,1000);
Console.WriteLine($"Выпало случайное число {number}");

int f = number % 100;
int s = f / 10;
Console.WriteLine(s);