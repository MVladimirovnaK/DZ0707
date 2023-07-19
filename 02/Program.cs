// Напишите программу, которая с помощью деления выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);  // модуль, если вдруг будет введено отрицательное число
if (number > 99)
{
    while(number > 999 )
    {
        number /=10;
    }
    Console.WriteLine($"Третья цифра числа: {number % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}